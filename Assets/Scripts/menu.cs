using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public AudioSource mouseclick;
    public AudioClip sfx3;

    public AudioSource voiceacting;
    public AudioClip sfx4;

    [SerializeField] 
    private float delayafterscene = 10f;

    [SerializeField]
    private float timeElapsed; 

    public void NextScene()
    {
        Time.timeScale = 1;
        voiceacting.Play();
        mouseclick.Play();

        timeElapsed += Time.deltaTime;
    
       if (timeElapsed > delayafterscene)
       {
            Debug.Log("Play Next Scene");
            SceneManager.LoadScene("Cutscene");
        }
            
    
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}