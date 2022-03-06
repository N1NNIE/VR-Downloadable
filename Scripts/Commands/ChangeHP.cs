using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHP : MonoBehaviour
{
    public bool needsValue = true;
    public CommandDatabase CommandDatabase;

    public void changeHP()
    {
        float value = float.Parse(CommandDatabase.valueInput.text);
        CommandDatabase.player.health = value;
        CommandDatabase.numberPad.SetActive(false);
        CommandDatabase.valueInput.gameObject.SetActive(false);
        CommandDatabase.inputField.text = "";
        CommandDatabase.valueInput.text = "";
        CommandDatabase.bools[1] = false;
    }
}
