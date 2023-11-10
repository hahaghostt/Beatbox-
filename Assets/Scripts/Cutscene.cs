using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Cutscene : MonoBehaviour
{
    public float delayInSeconds = 5f; 

    void Start()
    {
        Invoke("LoadNextScene", delayInSeconds);
    }

    void LoadNextScene()
    {
        
        SceneManager.LoadScene("Level 1");
    }
}
