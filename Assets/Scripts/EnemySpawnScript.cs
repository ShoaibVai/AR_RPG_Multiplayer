using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject enemyPrefab2;
    [SerializeField] private float initialSpawnInterval = 5f;
    [SerializeField] private float minSpawnInterval = 1f;
    [SerializeField] private float spawnIntervalDecrease = 0.05f;
    [SerializeField] private float spawnRadius = 3f;

    private float currentSpawnInterval;
    private Coroutine spawnCoroutine;

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        spawnCoroutine = StartCoroutine(SpawnEnemiesLoop());
    }

    private IEnumerator SpawnEnemiesLoop()
    {
        while (true)
        {
            SpawnEnemiesNearPlayers();
            yield return new WaitForSeconds(currentSpawnInterval);
            if (currentSpawnInterval > minSpawnInterval)
                currentSpawnInterval -= spawnIntervalDecrease;
        }
    }

    private void SpawnEnemiesNearPlayers()
    {
        var players = FindObjectsOfType<PlayerMovement>();
        foreach (var player in players)
        {
            Vector3 spawnPos = GetRandomPositionAround(player.transform.position);
            Quaternion spawnRot = Quaternion.identity;
            GameObject enemyPrefabToUse = Random.value < 0.5f ? enemyPrefab : enemyPrefab2;
            GameObject enemy = Instantiate(enemyPrefabToUse, spawnPos, spawnRot);
        }
    }

    private Vector3 GetRandomPositionAround(Vector3 center)
    {
        float angle = Random.Range(0f, Mathf.PI * 2);
        float distance = Random.Range(1f, spawnRadius);
        Vector3 offset = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * distance;
        return center + offset;
    }
} 