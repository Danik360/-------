using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class jump : MonoBehaviour
{
    public float velocity;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * velocity;
        }

    }
}
