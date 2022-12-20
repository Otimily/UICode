using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputUI : MonoBehaviour
{
    public InputField input;

    void Update()
    {
        Debug.Log(input.text);
    }
}
