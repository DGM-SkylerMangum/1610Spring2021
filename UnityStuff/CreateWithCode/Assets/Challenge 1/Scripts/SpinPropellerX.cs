using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject propeller;
    private float rotationSpeed = 300.0f;
    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
