using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;

    private float dir = 1f;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dir, 0f) * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dir *= -1;
    }
}
