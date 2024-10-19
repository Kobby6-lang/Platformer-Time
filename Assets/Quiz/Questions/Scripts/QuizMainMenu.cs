using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizMainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Game");

    }
    public void QuitGame()
    {
        //Application.Quit();
        SceneManager.LoadScene("Portfolio");
    }
}