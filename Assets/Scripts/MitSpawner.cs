using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitSpawner : MonoBehaviour
{
    public GameObject mits1Prefab;
    public float spawnInterval = 1.0f;  // Adjust the spawn interval as needed.
    private float timeSinceLastSpawn = 0.0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObject();
            timeSinceLastSpawn = 0.0f;
        }
    }

    void SpawnObject()
    {
        // Instantiate a new object from the prefab at the spawner's position.
        GameObject newObject = Instantiate(mits1Prefab, transform.position, Quaternion.identity);
    }
}