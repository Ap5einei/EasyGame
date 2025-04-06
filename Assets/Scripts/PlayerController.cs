using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float jumpForce = 1000;

    bool inAir = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!inAir) 
            {
                rb.AddForceAtPosition(Vector2.up * jumpForce, transform.position);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }

    private void OnCollisionExit2D (Collision2D colission)
    {
        inAir = true;
    }

}