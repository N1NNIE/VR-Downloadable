using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;

[Serializable]
public struct CommandSwitch
{
    public string command;
    public UnityEvent onCall;
}

[Serializable]
public struct CommandValue
{
    public string command;
}

public class CommandDatabase : MonoBehaviour
{
    [Header("The command presets.")]
    public CommandSwitch[] commandSwitch;
    public CommandValue[] commandsValue;
    [Header("The command scripts.")]
    public ChangeHP changeHP;
    public ChangeSpeed changeSpeed;
    public ChangeDamage changeDamage;
    [Header("Other")]
    public TMP_InputField inputField;
    public Player player;
    public TMP_InputField valueInput;
    public ButtonVR[] buttonsNumPads;
    public ButtonVR numberPadEnter;
    public GameObject numberPad;
    public bool[] bools;

    void ResetAll()
    {
        for (int i = 0; i < bools.Length; i++)
        {
            bools[i] = false;
        }

        for (int i = 0; i < buttonsNumPads.Length; i++)
        {
            buttonsNumPads[i].isPressed = false;
        }
    }

    void Start()
    {
        numberPad.SetActive(false);
        valueInput.gameObject.SetActive(false);
    }

    void Update()
    {
        if (bools[0])
        {
            if (valueInput.text != null && numberPadEnter.isPressed)
            {
                changeHP.changeHP();
                ResetAll();
            }
        }

        if (bools[1])
        {
            if (valueInput.text != null && numberPadEnter.isPressed)
            {
                changeSpeed.changeSpeed();
                ResetAll();
            }
        }

        if (bools[2])
        {
            if (valueInput.text != null && numberPadEnter.isPressed)
            {
                changeDamage.changeDamage();
                ResetAll();
            }
        }
    }

    public void ChangeHP(int value)
    {
        if (inputField.text == commandsValue[value].command)
        {
            numberPad.SetActive(true);
            valueInput.gameObject.SetActive(true);
            bools[0] = true;
        }
    }

    public void ChangeDamage(int value)
    {
        if (inputField.text == commandsValue[value].command)
        {
            numberPad.SetActive(true);
            valueInput.gameObject.SetActive(true);
            bools[2] = true;
        }
    }

    public void ChangeSpeed(int value)
    {
        if (inputField.text == commandsValue[value].command)
        {
            numberPad.SetActive(true);
            valueInput.gameObject.SetActive(true);
            bools[1] = true;
        }
    }

    public void CallCommand(int value)
    {
        if (inputField.text == commandSwitch[value].command)
        {
            commandSwitch[value].onCall.Invoke();
        }
    }
}
