using UnityEngine;
using System.Collections.Generic;
using System.Collections; 

public class MovingObject : MonoBehaviour
{
    // coding makes me cry
    public float speed = 1.5f;  // Adjust the speed as needed.
    private Transform player;

    void Start()
    {
        player = Camera.main.transform;  // Assuming the player's camera is the main camera.
    }

    void Update()
    {
        // Move the object towards the player's position.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void DestroyObject()
    {
        // Add any desired destruction effect (e.g., play a particle system, play a sound).
        Destroy(gameObject);
    }
}