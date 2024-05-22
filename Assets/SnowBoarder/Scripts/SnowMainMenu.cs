using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowMainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Snow Level");

    }
    public void QuitGame()
    {
        //Application.Quit();
        SceneManager.LoadScene("Portfolio");
    }
}
