using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitSpawner : MonoBehaviour
{
    public GameObject mits1Prefab;
    public float beatInterval = 1.0f;  // Time between beats in seconds
    public float bpm = 160;            // Beats per minute
    public float startDelay = 2.0f;   // Delay before the first beat
    public float scrollSpeed = 5.0f;  // Speed at which the objects scroll forward

    private float nextBeatTime;

    void Start()
    {
        nextBeatTime = startDelay;
    }

    void Update()
    {
        if (Time.time >= nextBeatTime)
        {
            // Spawn the mits
            GameObject beatInstance = Instantiate(mits1Prefab, transform.position, Quaternion.identity);

            
            Rigidbody rb = beatInstance.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * scrollSpeed;
            }

            
            float beatDuration = 60.0f / bpm;
            nextBeatTime += beatDuration;
        }
    }
} 