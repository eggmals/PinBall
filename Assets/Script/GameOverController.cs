using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GmaeOverController : MonoBehaviour
{
    public Button mainmenuButton;

    private void Start()
    {
        mainmenuButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
