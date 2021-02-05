using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;

    void Start()
    {
        Debug.Log("Active Self: " + ball.activeSelf);
        Debug.Log("Active in Hierarchy" + ball.activeInHierarchy);
    }
}
