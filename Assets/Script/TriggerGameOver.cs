using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
