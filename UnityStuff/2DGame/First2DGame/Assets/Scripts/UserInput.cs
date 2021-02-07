using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float speedModifier = 1f;
    public Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVir = Input.GetAxis("Vertical");
        Vector2 theMovement = new Vector2(moveHor, moveVir);
        rb2d.AddForce(theMovement * speedModifier * Time.deltaTime);
    }

}
