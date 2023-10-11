using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;


public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        if (scoreManager != null)
        {
            scoreText.text = "Score: " + scoreManager.GetScore();
        }
    }
}