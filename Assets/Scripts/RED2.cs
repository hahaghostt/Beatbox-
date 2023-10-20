using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class RED2 : MonoBehaviour
{
    public AudioClip sfx1;
    public int pointsToAdd = 10;

    [SerializeField] GameObject Firework;

    private XRNode controllerNode;
    private InputDevice device;
    private float punchThreshold = 2.0f;

    private void Start()
    {
        controllerNode = GetControllerNode(this.gameObject);
        device = InputDevices.GetDeviceAtXRNode(controllerNode);
    }

    private void Update()
    {
        if (IsPunch())
        {
            HandlePunch();
        }
    }

    private bool IsPunch()
    {
        Vector3 velocity;
        if (device.TryGetFeatureValue(CommonUsages.deviceVelocity, out velocity) && velocity.magnitude > punchThreshold)
        {
            return true;
        }

        return false;
    }

    private void HandlePunch()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0.5f);

        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("DestroyableTag4"))
            {
                ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
                if (scoreManager != null)
                {
                    scoreManager.IncreaseScore(pointsToAdd);
                }

                AudioSource src = hitCollider.GetComponent<AudioSource>();
                if (src != null)
                {
                    src.Play();
                }

                GameObject explosion = Instantiate(Firework, hitCollider.transform.position, Firework.transform.rotation);
                Destroy(explosion, 0.75f);
                Destroy(hitCollider.gameObject);
            }
            else if (hitCollider.CompareTag("DestroyableTag2"))
            {
                Destroy(hitCollider.gameObject);
            }
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
        return XRNode.RightHand;
    }
}