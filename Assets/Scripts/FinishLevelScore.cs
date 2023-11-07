using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FinishLevelScore : MonoBehaviour
{
    // Add this function to a button's click event or a trigger event in your game.
    public Canvas mainMenuCanvas;
    public GameObject SceneStart; 

    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        mainMenuCanvas.enabled = false;
        SceneManager.LoadScene("2nd Menu");
    }

    public void ContinueToNextLevel()
    {
        Time.timeScale = 1;
        ReplayGame(); 
        SceneManager.LoadScene("Level 2");
        Debug.Log("BUTTON PRESSED");
        Time.timeScale = 1;
        ReplayGame(); 
        mainMenuCanvas.enabled = true;

    }

    public void RetryAgain()
    {
        SceneManager.LoadScene("Level 1"); 
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits"); 
    }

    void ReplayGame()
    {
        Time.timeScale = 1; 
    }

    void PlayGame()
    {
        Time.timeScale = 1; 
    }



    // 156 
    // 141
}