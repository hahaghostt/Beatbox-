using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;

public class RED : MonoBehaviour
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

    public GameObject xrController;






    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("DestroyableTag4"))
        {
            /* score.AddScore(1); */
            Src = GameObject.FindWithTag("DestroyableSound");

            src = Src.GetComponent<AudioSource>();

            XRNode controllerNode = GetControllerNode(this.gameObject);
            InputDevice device = InputDevices.GetDeviceAtXRNode(controllerNode);
            device.SendHapticImpulse(0, 0.5f, 0.5f);

            /*if (IsPunch())
            {
                // Handle the punch action
                HandlePunch(collision.gameObject);
            } */ 


            ScoreManager scoreManager = GameObject.FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(pointsToAdd);
            }

            src.Play();

            GameObject explosion = Instantiate(Firework, transform.position, Firework.transform.rotation);
            /* Firework.Play(); */
            Destroy(explosion, 0.75f);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("DestroyableTag2"))
        {
            Destroy(gameObject);
        }
    }

    /* private bool IsPunch()
    {
        XRNode controllerNode = GetControllerNode(xrController);
        InputDevice device = InputDevices.GetDeviceAtXRNode(controllerNode);

        
        // For example, you can use device.TryGetFeatureValue to check the controller's velocity
        /* Vector3 velocity;
        if (device.TryGetFeatureValue(CommonUsages.velocity, out velocity))
        {
            // Adjust the threshold and direction according to your needs
            float punchThreshold = 2.0f;
            Vector3 punchDirection = Vector3.forward;

            if (Vector3.Dot(velocity, punchDirection) > punchThreshold)
            {
                return true;
            }
        }

        return false; 
    } */ 

 
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