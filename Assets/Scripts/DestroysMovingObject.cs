using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DestroysMovingObject : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1; 
    // This function is called when a collision occurs.
    public void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer.
        if (collision.gameObject.CompareTag("DestroyableTag"))
        {
            // Destroy the object that this script is attached to.
            Destroy(gameObject);

            Debug.Log("Destroy Mit");
            src.clip = sfx1;
            src.Play(); 
        }
    }
}