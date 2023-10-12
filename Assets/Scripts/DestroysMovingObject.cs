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

    [SerializeField] GameObject Firework; 
    /*
    public GameObject Score;
    public int theScore = 0;

    public ScoreSystem score; 
    */ 

    void update()
    {
       // Firework part = GetComponent<ParticleSystem>(); 
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

            /* var part = GetComponent<ParticleSystem>();
            part.Play();
            Destroy(gameObject, part.main.duration); */

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
}