using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public AudioSource mouseclick;
    public AudioClip sfx3;

    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
        mouseclick.Play();
    }
}