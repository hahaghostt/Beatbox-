using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unpause : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
        Debug.Log("Unpause Game"); 
    }
}
