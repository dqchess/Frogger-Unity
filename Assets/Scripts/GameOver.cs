using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public static int highscore;
    public static int score;

    void Start()
    {
        score = Score.cscore;
        Debug.Log(score);
        scoreText.text = "Score : " + score.ToString();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        if (score > highscore)
            PlayerPrefs.SetInt("highscore", score);
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        highscoreText.text = "High Score : " + highscore;
    }

    public void Replay()
    {
        Score.cscore = 0;
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        Score.cscore = 0;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
