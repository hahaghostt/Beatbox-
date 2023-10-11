using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMitObject : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer.
        if (collision.gameObject.CompareTag("DestroyableTag"))
        {
            Destroy(gameObject);
        }
    }
}
