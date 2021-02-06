using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float range;

    void Update()
    {
        float moveSpeed = Input.GetAxis("Horizontal");
        float xPos = moveSpeed * range;
    transform.position = new Vector3(xPos, 0, 0);
    }

}
