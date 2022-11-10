using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;

    void Start()
    {
        SpawnPlayer();
        
    }

    void SpawnPlayer()
    {
        Instantiate(player, spawnPoint.transform.position, Quaternion.identity);
        
    }

    
}
