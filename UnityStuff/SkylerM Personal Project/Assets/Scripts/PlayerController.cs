using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10.0f;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
}
