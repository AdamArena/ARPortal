using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour
{
    public string theText;
    public GameObject inputField;
    public GameObject displayText;

    public void StoreText()
    {
        theText = inputField.GetComponent<Text>().text;
        displayText.GetComponent<Text>().text = "Text: " + theText + "...was captured";
    }

    public void StoreName()
    {
        theText = inputField.GetComponent<Text>().text;
        displayText.GetComponent<Text>().text = "Text: " + theText + "...was captured";
    }
}
