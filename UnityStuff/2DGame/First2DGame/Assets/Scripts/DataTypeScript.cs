using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    void Update()
    {
        //Value type variable
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos = new Vector3(0, 2f, 0);
        }
        //Reference type variable
        Transform tran = transform;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tran.position = new Vector3(1, 2, 1);
        }
    }
}
