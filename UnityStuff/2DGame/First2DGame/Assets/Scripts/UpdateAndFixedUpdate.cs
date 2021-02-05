using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    /* Called every physics step, these intervals are consistant
     * and are to be used for regular updates like adjusting ridgidbody objects
     */
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
