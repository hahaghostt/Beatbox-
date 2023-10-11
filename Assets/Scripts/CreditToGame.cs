using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CreditToGame : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DestroyableTag3"))
        {
            SceneManager.LoadScene("2nd menu");
        }
    }
}
