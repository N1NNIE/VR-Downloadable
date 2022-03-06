using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommandStats : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI health;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI damage;

    void Start()
    {
        
    }

    void Update()
    {
        health.text = player.health.ToString();
        speed.text = player.ovrPlayer.Acceleration.ToString();
        damage.text = player.damage.ToString();
    }
}
