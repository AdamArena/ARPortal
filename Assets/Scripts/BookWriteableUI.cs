using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookWriteableUI : MonoBehaviour
{
    public TMP_InputField bookTitleInput;
    public TMP_InputField bookDescriptionInput;
    public TMP_InputField userName;


    public void OnCreateBookClicked ()
    {
        GameManager.CreateNewBook(bookTitleInput.text, bookDescriptionInput.text, userName.text, System.DateTime.Now.ToString());
        GameManager.SaveNewBook(bookTitleInput.text, bookDescriptionInput.text, userName.text, System.DateTime.Now.ToString());
        bookTitleInput.text = "";
        bookDescriptionInput.text = "";
        userName.text = "";
        gameObject.SetActive(false);
    }   
}
