using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;

public class DestroysMovingObject : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public GameObject Src;
    public int pointsToAdd = 10;

    [SerializeField] GameObject Firework;

    /*
    public GameObject Score;
    public int theScore = 0;

    public ScoreSystem score; 
    */

    public bool isPunching = false;
    public Vector3 previousPosition;

    void Update()
    {
        // Check for punch motion by calculating the velocity of the controller.
        XRNode controllerNode = GetControllerNode(this.gameObject);
        InputDevice device = InputDevices.GetDeviceAtXRNode(controllerNode);

        Vector3 currentPosition;
        if (device.TryGetFeatureValue(CommonUsages.devicePosition, out currentPosition))
        {
            
            float velocity = (currentPosition - previousPosition).magnitude / Time.deltaTime;

            
            if (velocity > 2.0f) 
            {
                isPunching = true;
            }
            else
            {
                isPunching = false;
            }
            previousPosition = currentPosition;
        }
    }


    // This function is called when a collision occurs.
    public void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer.
        if (collision.gameObject.CompareTag("DestroyableTag"))
        {
            /* score.AddScore(1); */ 
            Src = GameObject.FindWithTag("DestroyableSound");

            src = Src.GetComponent<AudioSource>();

            XRNode controllerNode = GetControllerNode(this.gameObject);
            InputDevice device = InputDevices.GetDeviceAtXRNode(controllerNode);
            device.SendHapticImpulse(0, 0.5f, 0.1f);


            ScoreManager scoreManager = GameObject.FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(pointsToAdd);
            }

            src.Play();

            GameObject explosion = Instantiate(Firework, transform.position,  Firework.transform.rotation);
            /* Firework.Play(); */
            Destroy(explosion, 0.75f); 
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("DestroyableTag2"))
        {
            Destroy(gameObject); 
        }
    }
    private XRNode GetControllerNode(GameObject controller)
    {
        if (controller.name.Contains("Right"))
        {
            return XRNode.RightHand;
        }
        else if (controller.name.Contains("Left"))
        {
            return XRNode.LeftHand;
        }
        // Return the default value if not found
        return XRNode.RightHand;
    }
}