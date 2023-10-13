using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text countdownText;
    public float totalTime = 60.0f; 

    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime; 
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        currentTime = Mathf.Max(0, currentTime);

        UpdateCountdownText(); 

        if (currentTime <= 0)
        {
            Debug.Log("Countdown Finish"); 
        }
    }

    void UpdateCountdownText()
    {
        int seconds = Mathf.CeilToInt(currentTime);
        countdownText.text = "TIMER:" + seconds.ToString(); 
    }
}
