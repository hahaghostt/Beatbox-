using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderManager : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public int requiredTouches = 3;
    public float comboResetTime = 2.0f; // Time in seconds before combo resets
    public ScoreManager scoreManager; // Reference to the ScoreManager script

    private int touchCount = 0;
    private int comboMultiplier = 1;
    private float lastTouchTime = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            touchCount++;
            comboMultiplier = Mathf.Max(comboMultiplier, touchCount / requiredTouches + 1);
            lastTouchTime = Time.time;

            if (touchCount >= requiredTouches)
            {
               
                SceneManager.LoadScene("YourSceneName");
            }

     
            Vector3 spawnPosition = transform.position + transform.forward * (2.0f * comboMultiplier);
            Instantiate(prefabToInstantiate, spawnPosition, Quaternion.identity);

           
            int scoreToAdd = 100 * comboMultiplier;
            scoreManager.IncreaseScore(scoreToAdd);
        }
    }

    private void Update()
    {
        if (Time.time - lastTouchTime >= comboResetTime)
        {
           
            comboMultiplier = 1;
            touchCount = 0;
        }
    }
}







