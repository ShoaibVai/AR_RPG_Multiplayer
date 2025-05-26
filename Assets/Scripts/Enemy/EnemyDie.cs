using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    private int hitCount;

    private void Update()
    {

        // if bullet collides with the enemy for 3 times then enemy is destroyed or died
        if(hitCount >= 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            hitCount++;
        }
    }
}
