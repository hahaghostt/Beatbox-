using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DestroysMovingObject : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public GameObject Src;
    public int pointsToAdd = 10;
    /*
    public GameObject Score;
    public int theScore = 0;

    public ScoreSystem score; 
    */ 

    
    // This function is called when a collision occurs.
    public void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer.
        if (collision.gameObject.CompareTag("DestroyableTag"))
        {
            /* score.AddScore(1); */ 
            Src = GameObject.FindWithTag("DestroyableSound");

            src = Src.GetComponent<AudioSource>();
            /*  Score = GameObject.FindWithTag("UIScoreMultiplier");
              theScore += 1;
             Score.GetComponent<Text>().text = "0" + theScore; */
            ScoreManager scoreManager = GameObject.FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(pointsToAdd);
            }

            src.Play(); 
            // Destroy the object that this script is attached to.
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("DestroyableTag2"))
        {
            Destroy(gameObject); 
        }
    }
}