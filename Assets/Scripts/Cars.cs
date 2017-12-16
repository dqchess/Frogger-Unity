using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour {

    float speed = 1f;
    public float minspeed = 8f;
    public float maxsped = 12f;
    public Rigidbody2D rb;

    void Start()
    {
        speed = Random.Range(minspeed, maxsped);
    }

    void Update () {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}
}