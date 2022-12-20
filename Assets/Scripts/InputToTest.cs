using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputToTest : MonoBehaviour
{
    public InputField input;
    public Text text;
    public Color delicious;



    void Start()
    {
        Debug.Log(input.text);
    }
    
    public void click()
    {
        text.text = text.text + "\n"+ input.text;
        text.fontSize = 20;
        text.color = delicious;
        text.fontStyle = FontStyle.Bold;
    }
}
