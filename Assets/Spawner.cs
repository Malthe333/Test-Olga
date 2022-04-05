using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Rigidbody rb;
    
    public GameObject Box;

    public  Transform spawnPoint;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SpawnObject()
    {
        Instantiate(Box, spawnPoint.position, Quaternion.identity);

    }
}
