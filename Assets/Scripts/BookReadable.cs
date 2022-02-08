using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookReadable : MonoBehaviour
{
    [HideInInspector] public string title;
    [HideInInspector] public string description;
    [HideInInspector] public string userName;
    [HideInInspector] public string date;

    public void OnMouseDown()
    {
        Debug.Log("This was pressed");

        BookReadableUI ui = GameObject.FindObjectOfType<BookReadableUI>(true);
        Debug.Log(ui.name);
        ui.bookTitleText.text = title;
        ui.bookDescriptionText.text = description;
        ui.userName.text = userName;
        ui.bookDateText.text = date;
        ui.gameObject.SetActive(true);
    }
}
