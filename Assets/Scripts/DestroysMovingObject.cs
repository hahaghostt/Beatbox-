using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DestroysMovingObject : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public GameObject Src; 

    
    // This function is called when a collision occurs.
    public void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer.
        if (collision.gameObject.CompareTag("DestroyableTag"))
        {
            Src = GameObject.FindWithTag("DestroyableSound");

            src = Src.GetComponent<AudioSource>();

            src.Play(); 
            // Destroy the object that this script is attached to.
            Destroy(gameObject);
        }
    }
}