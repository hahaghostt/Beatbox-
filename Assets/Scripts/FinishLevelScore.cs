using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FinishLevelScore : MonoBehaviour
{
    // Add this function to a button's click event or a trigger event in your game.
    public Canvas mainMenuCanvas;

    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        mainMenuCanvas.enabled = false;
        SceneManager.LoadScene("2nd Menu");
    }

    public void ContinueToNextLevel()
    {
        SceneManager.LoadScene("Level 2"); 

    }


}