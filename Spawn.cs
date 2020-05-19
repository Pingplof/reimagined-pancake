using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnSpot; 
    private int randonSpawn;
    void Start()
    {
        randonSpawn = Random.Range(0, spawnSpot.Length);
        transform.position = spawnSpot[randonSpawn].position;
    }
}
