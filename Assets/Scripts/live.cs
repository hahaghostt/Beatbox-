using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class live : MonoBehaviour
{
    public int requiredItems = 10;
    public TMPro.TextMeshProUGUI counterProgess;
    public int unwantedItems = 0;
    public int nextLevel = 0;
    public string counterText;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        unwantedItems += 1;
    }

    // Update is called once per frame
    void Update()
    {
        counterText = "";
        counterText += unwantedItems.ToString();
        counterText += "/";
        counterText += requiredItems.ToString();
        counterText += " items ";

        counterProgess.text = counterText;

        if (unwantedItems >= requiredItems)
        {
            Debug.Log("FHFHFF");
            SceneManager.LoadScene(nextLevel);
        }
    }
}
