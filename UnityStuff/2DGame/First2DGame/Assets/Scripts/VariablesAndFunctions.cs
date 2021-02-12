using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 5;
    public int mySecondInt = 10;
    // Start is called before the first frame update
    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
    int AddingTheOtherInt(int number, int otherNum)
    {
        int ret;
        number += otherNum;
        ret = number;
        return ret;
    }
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        myInt = AddingTheOtherInt(myInt, mySecondInt);
        Debug.Log(myInt);
    }
}
