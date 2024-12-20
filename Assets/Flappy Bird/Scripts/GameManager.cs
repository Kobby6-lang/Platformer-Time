using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] public Text scoreText;

    [SerializeField] private GameObject playButton;

    [SerializeField] private GameObject gameOver;

    [SerializeField] private GameObject quitButton;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        quitButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        quitButton.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void QuitGame() 
    {
        SceneManager.LoadSceneAsync("Portfolio");
    }
}
