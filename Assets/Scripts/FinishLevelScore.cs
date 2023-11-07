using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FinishLevelScore : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public GameObject SceneStart;

    // Add a reference to your GameObject that starts the game.
    public GameObject gameStarter;

    // Add this function to a button's click event or a trigger event in your game.
    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        mainMenuCanvas.enabled = false;
        SceneManager.LoadScene("2nd Menu");
    }

    public void ContinueToNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 2");
        Debug.Log("BUTTON PRESSED");
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

    // Add a method to start the game and unpause it.
    public void StartGameAndUnpause()
    {
        // Start the game or do any necessary setup.
        // For example, you can activate your SceneStart GameObject here if needed.
        if (gameStarter != null)
        {
            gameStarter.SetActive(true);
        }

        // Unpause the game by setting Time.timeScale to 1.
        Time.timeScale = 1;
    }

    // Automatically unpause the scene when it loads.
    private void Start()
    {
        Time.timeScale = 1;
    }

    // 156
    // 144
}