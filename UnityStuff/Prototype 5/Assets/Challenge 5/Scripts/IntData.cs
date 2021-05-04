using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    // Start is called before the first frame update
    protected int value;
    public void UpdateValue(int number)
    {
        value += number;
    }

    // Update is called once per frame
    public void ReplaceValue(int number)
    {
        value = number;
    }
    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }
    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
