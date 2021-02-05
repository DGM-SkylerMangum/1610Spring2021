using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 5;
    // Start is called before the first frame update
    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
}
