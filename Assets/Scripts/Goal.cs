using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.cscore += 1;
        Vector2 pos = new Vector2(0f, -4.8f);
        rb.position = pos;
    }
}
