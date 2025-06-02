using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : NetworkBehaviour
{
    [SerializeField] private Button restartButton;

    public static event Action OnRestartGame;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(() => RestartGameServerRpc());
        
    }

    [ServerRpc(RequireOwnership = false)]
    void RestartGameServerRpc()
    {
        // Find all game objects with the "enemy" tag and destroy them
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        // Invoke the client RPC to trigger the OnRestartGame event
        RestartGameClientRpc();
    }

    [ClientRpc]
    void RestartGameClientRpc()
    {
        OnRestartGame?.Invoke();
    }

}
