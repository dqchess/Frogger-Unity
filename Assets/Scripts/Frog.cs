using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

    public Rigidbody2D rb;
    int scores;

	void Update () {
		if((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && rb.position.x<10f)
            rb.MovePosition(rb.position + Vector2.right);
        else if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && rb.position.x > -10f)
            rb.MovePosition(rb.position + Vector2.left);
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && rb.position.y < 3f)
            rb.MovePosition(rb.position + Vector2.up);
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && rb.position.y > -4f)
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Car")
        {
            scores = Score.cscore;
            PlayerPrefs.SetInt("Score", scores);
            SceneManager.LoadScene(2);
        }
    }
}
