using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void IncreaseScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }

}
