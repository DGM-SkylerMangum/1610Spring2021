using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private float turnspeed = 45.0f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    // Update is called once per frame
    void FixedUpdate()
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
