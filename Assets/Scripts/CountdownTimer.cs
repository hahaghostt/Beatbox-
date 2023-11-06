using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text countdownText;
    public float totalTime = 60.0f;
    private float currentTime;
    public Canvas canvas;
    public AudioSource goodjob;
    public AudioClip sfx3;
    public GameObject Goodjob; 



    void Start()
    {
        currentTime = totalTime;
        canvas.enabled = false;
    }

    
    void Update()
    {
        currentTime -= Time.deltaTime;
        currentTime = Mathf.Max(0, currentTime);

        UpdateCountdownText(); 

        if (currentTime <= 0)
        {
            Debug.Log("Countdown Finish");
            PauseGame();
            ShowEndUI(); 

        }
    }

    void UpdateCountdownText()
    {
        int seconds = Mathf.CeilToInt(currentTime);
        countdownText.text = "TIMER:" + seconds.ToString(); 
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ShowEndUI()
    {
        canvas.enabled = true;
       /* GoodJob  = GameObject.FindWithTag("GoodJob2");

        goodjob = GoodJob.GetComponent<AudioSource>(); */ 
    }
}
