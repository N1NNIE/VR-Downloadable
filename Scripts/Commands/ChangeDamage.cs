using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDamage : MonoBehaviour
{
    public bool needsValue = true;
    public CommandDatabase CommandDatabase;

    public void changeDamage()
    {
        float value = float.Parse(CommandDatabase.valueInput.text);
        CommandDatabase.player.damage = value;
        CommandDatabase.numberPad.SetActive(false);
        CommandDatabase.valueInput.gameObject.SetActive(false);
        CommandDatabase.inputField.text = "";
        CommandDatabase.valueInput.text = "";
        CommandDatabase.bools[2] = false;
    }
}
