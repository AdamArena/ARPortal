using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldToText : MonoBehaviour
{
    public TMP_InputField field;
    public TMP_Text textBox;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CopyText()
    {
        textBox.text = field.text;
    }
}
