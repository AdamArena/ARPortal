using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseContent : MonoBehaviour
{
    public CinchDBDatabase database;
    public InputField nameField;
    public InputField messageField;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CinchDBRecord messageRecord = new CinchDBRecord(nameField.text, messageField.text, System.DateTime.Now.ToString());
            CinchDB.AddRecords(database, messageRecord);
            Debug.Log(messageRecord);
        }
    }
}
