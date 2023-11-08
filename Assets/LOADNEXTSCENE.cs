using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENELOADER : MonoBehaviour
{
    public float delay = 440;
    public string NewLevel = "2nd menu";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}