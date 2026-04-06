using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public ScoreManager scoreManager;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
