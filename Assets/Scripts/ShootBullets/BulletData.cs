using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class BulletData : NetworkBehaviour
{
    [SerializeField] private float searchRadius = 5f; // Radius to search for enemies around the player
    [SerializeField] private string enemyTag = "Enemy"; // Tag of enemy objects

    private NetworkVariable<ulong> owner = new(999);
    private NetworkVariable<bool> isActiveSelf = new(true);

    public static event Action<(ulong from, ulong to)> OnHitPlayer; 

    private const int MAX_FLY_TIME = 10;

    private float moveSpeed = 10f; // Speed of the bullet

    void Update()
    {
        // ... existing code ...
    }

    public override void OnNetworkSpawn()
    {
        DeactivateSelfDelay();
    }


    [ServerRpc(RequireOwnership = false)]
    public void SetOwnershipServerRpc(ulong id)
    {
        this.owner.Value = id;
    }


    [ServerRpc(RequireOwnership = false)]
    public void SetBulletIsActiveServerRpc(bool isActive)
    {
        if(!GetComponent<NetworkObject>()) return;
        
        
        isActiveSelf.Value = isActive;

        if (isActive == false)
        {
            GetComponent<NetworkObject>().Despawn();
        }
        else
        {
            GetComponent<NetworkObject>().Spawn();
        }
    }


    public void DeactivateSelfDelay()
    {
        StartCoroutine(DeactivateSelfDelayCoroutine());
    }

    IEnumerator DeactivateSelfDelayCoroutine()
    {
        yield return new WaitForSeconds(MAX_FLY_TIME);
        SetBulletIsActiveServerRpc(false);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (IsServer)
        {
            if (collision.transform.TryGetComponent(out NetworkObject networkObject))
            {
                if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
                {
                    Debug.Log("Bullet has Collision to player");
                    (ulong, ulong) fromShooterToHit = new(owner.Value, networkObject.OwnerClientId);
                    OnHitPlayer?.Invoke(fromShooterToHit);
                    SetBulletIsActiveServerRpc(false);
                    return;
                }
            }
            else
            {
                SetBulletIsActiveServerRpc(false);
            }
        }
    }

    private Transform FindNearestEnemy()
    {
        if (owner.Value == 999) // Default value, means owner is not set yet
        {
            return null; // Cannot search without an owner
        }

        // Find the player object based on owner ID
        NetworkObject playerNetworkObject = null;
        foreach (var spawnedObject in NetworkManager.Singleton.SpawnManager.SpawnedObjects.Values)
        {
            if (spawnedObject.OwnerClientId == owner.Value)
            {
                playerNetworkObject = spawnedObject;
                break;
            }
        }

        if (playerNetworkObject == null)
        {
            Debug.LogWarning($"Player object with OwnerClientId {owner.Value} not found.");
            return null; // No player object found with the specified owner
        }

        // Search for enemies around the player's position
        Collider[] hitColliders = Physics.OverlapSphere(playerNetworkObject.transform.position, searchRadius);
        Transform nearestEnemy = null;
        float closestDistanceSq = Mathf.Infinity;

        foreach (var hitCollider in hitColliders)
        {
            // Ensure we don't target the owner or other players if player objects have the enemy tag
            if (hitCollider.transform.TryGetComponent(out NetworkObject targetNetworkObject))
            {
                if (targetNetworkObject.OwnerClientId == owner.Value) continue; // Skip the owner
            }
            
            if (hitCollider.CompareTag(enemyTag))
            {
                float distanceSq = (hitCollider.transform.position - transform.position).sqrMagnitude;
                if (distanceSq < closestDistanceSq)
                {
                    closestDistanceSq = distanceSq;
                    nearestEnemy = hitCollider.transform;
                }
            }
        }

        return nearestEnemy;
    }
}
