using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;
    public GameObject h2pText;
    public GameObject actuallyStartButton;

    public void StartButton()
    {
        quitButton.SetActive(false);
        h2pText.SetActive(true);
        actuallyStartButton.SetActive(true);
        startButton.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void ActuallyStartButton()
    {
        SceneManager.LoadScene("Main Game");
    }
}
