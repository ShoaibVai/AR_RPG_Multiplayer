using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    private int hitCount;

    

    private void OnCollisionEnter(Collision collision)
    {
        // if Enemy collides with bullet or player it destroyes itself
        if (collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("Player"))
        {
            Destroy(transform.gameObject);

        }
    }
}
