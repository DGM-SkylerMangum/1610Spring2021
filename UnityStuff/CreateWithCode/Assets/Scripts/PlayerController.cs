using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 2.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * 20 * speed * forwardInput);
        //rotates
        transform.Rotate(Vector3.up, turnspeed * horizontalInput* Time.deltaTime);
    }
}
