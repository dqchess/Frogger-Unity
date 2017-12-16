using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int cscore = 0;

    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score : " + cscore.ToString();
    }
}
