using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Start is called before the first frame update

    public TMP_InputField field;
    public TMP_Text textBox;

    public CinchDBDatabase messageDatabase;

    public static BookReadable[] readableBooks;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        readableBooks = GameObject.FindObjectsOfType<BookReadable>(true);
        foreach (BookReadable book in readableBooks)
        {
            book.gameObject.SetActive(false);
        }

        LoadBooksFromDatabase();
        
    }

    public async void LoadBooksFromDatabase ()
    {
        List<CinchDBRecord> records = await CinchDB.GetAllRecords(messageDatabase);
        foreach (CinchDBRecord record in records)
        {
            CreateNewBook(record.Columns[0], record.Columns[1], record.Columns[2], record.Columns[3]);
        }
    }

    public static void SaveNewBook(string title, string description, string userName, string date)
    {
        CinchDBRecord record = new CinchDBRecord(title, description, userName, date);
        CinchDB.AddRecords(Instance.messageDatabase, record);
    }

    public static void CreateNewBook(string title, string description, string userName, string date)
    {
        foreach (BookReadable book in readableBooks)
        {
            if (!book.gameObject.activeSelf)
            {
                book.gameObject.SetActive(true);
                book.title = title;
                book.description = description;
                book.userName = userName;
                book.date = date;
                break;
            }
        }
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

