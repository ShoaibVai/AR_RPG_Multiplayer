using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    // References
    private Transform playerTransform; // to track the distance

    [SerializeField] private float rotationSpeed = 300f;
    [SerializeField] private float moveSpeed = 30f;
    private void Start()
    {
        // Finding the player tagged object and receiving its transform component
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        transform.position =new Vector3(transform.position.x, playerTransform.position.y, transform.position.z);
    }

    private void Update()
    {
        EnemyLookat();
        EnemyChase();
    }

    // making the enemy lookat the player
    private void EnemyLookat()
    {
        if(playerTransform != null)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;

            direction.y = 0; // ingnore the y differences

            if(direction != Vector3.zero)
            {
                Quaternion targetrotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, rotationSpeed * Time.deltaTime);
            }
        }
    }

    // Enemy chase
    private void EnemyChase()
    {
        if(playerTransform != null)
        {
            // Distance will be used if we emplement a stopping condision of chasing
            // as i am not diong that and emeny must collide with the palyer to execute player damage
            // so distance is unused in this context
            float distance = Vector3.Distance(transform.position, playerTransform.position);


            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, moveSpeed *Time.deltaTime);
        }
    }
}
