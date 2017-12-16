using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text highscoreText;
    int highscore;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        highscoreText.text = highscore.ToString();
    }

    public void PlayGame()
    {
        StartCoroutine(ExecuteAfterTime ());
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}