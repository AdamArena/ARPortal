using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookReadableUI : MonoBehaviour
{
    public TextMeshProUGUI bookTitleText;
    public TextMeshProUGUI bookDescriptionText;
    public TextMeshProUGUI userName;
    public TextMeshProUGUI bookDateText;

    public void OnCloseBookClicked()
    {
        gameObject.SetActive(false);
    }
}
