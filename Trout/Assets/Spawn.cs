using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Player;
    public Transform spawnPoint;

    void Start()
    {
        SpawnPlayer();
        
    }

    void SpawnPlayer()
    {
        Instantiate(Player, spawnPoint.transform.position, Quaternion.identity);
        
    }

    
}
