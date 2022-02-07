using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookWriteable : MonoBehaviour
{
    public GameObject Canvas;

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Canvas.SetActive(true);
    }

}
    
