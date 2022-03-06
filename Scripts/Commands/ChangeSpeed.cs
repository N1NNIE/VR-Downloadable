using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public bool needsValue = true;
    public CommandDatabase CommandDatabase;

    public void changeSpeed()
    {
        float value = float.Parse(CommandDatabase.valueInput.text);
        CommandDatabase.player.ovrPlayer.Acceleration = value;
        CommandDatabase.numberPad.SetActive(false);
        CommandDatabase.valueInput.gameObject.SetActive(false);
        CommandDatabase.inputField.text = "";
        CommandDatabase.valueInput.text = "";
        CommandDatabase.bools[0] = false;
    }
}
