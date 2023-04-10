using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    public Transform ball;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    private void FixedUpdate()
    {
        if (ball.position.y > transform.position.y)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (ball.position.y < transform.position.y)
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}

