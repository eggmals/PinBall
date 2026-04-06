using System;
using System.Collections;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public float score;

    private void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        score += addition;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
