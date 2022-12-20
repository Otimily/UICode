using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewValue : MonoBehaviour
{
    public Text t;
    public Color c;

        void Start()
    {
        string sr = "µð¹ö±×ÀÔ´Ï´Ù.";

        Debug.Log(t.text); //New Text

        t.text = "ÄíÅ°·±Å·´ý";

        Debug.Log(t.text); //ÄíÅ°·±Å·´ý

        //t.text = "ÄíÅ°·±Å·´ý!";
        //t.fontSize = 200;
        //t.color = c;
        //t.fontStyle = FontStyle.Bold;
    }
}
