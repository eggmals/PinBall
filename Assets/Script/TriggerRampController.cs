using System;
using System.Collections;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;
    public Collider bola;
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
           scoreManager.AddScore(score); 
        }
    }
}
