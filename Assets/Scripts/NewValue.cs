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
        string sr = "������Դϴ�.";

        Debug.Log(t.text); //New Text

        t.text = "��Ű��ŷ��";

        Debug.Log(t.text); //��Ű��ŷ��

        //t.text = "��Ű��ŷ��!";
        //t.fontSize = 200;
        //t.color = c;
        //t.fontStyle = FontStyle.Bold;
    }
}
