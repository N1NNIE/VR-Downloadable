using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterButton : MonoBehaviour
{
    Keyboard keyboard;
    TextMeshProUGUI buttonText;
    public TMP_InputField id;

    void Start()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();

        if (id.text.Length == 1)
        {
            GetComponentInChildren<Enter>().onRelease.AddListener(delegate { keyboard.InsertChar(id.text); });
        }
    }

    public void NameToButtonText()
    {
        buttonText.text = gameObject.name;
    }
}
