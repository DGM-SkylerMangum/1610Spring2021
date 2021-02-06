using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public float moveSpeed = 5f;
    public float jumping = 10f;
    private Vector2 sideMovement;
    private Vector2 jumpMovement;

    void Update()
    {
        sideMovement.x = Input.GetAxis("Horizontal") * moveSpeed;
        if (!Input.GetButtonDown("Jump")) return;
        jumpMovement.y = jumping;
    }
    void FixedUpdate()
    {
        ballRigidbody2D.AddForce(0f, 0f);
        ballRigidbody2D.AddForce(jumpMovement, 0f);
    }

}
