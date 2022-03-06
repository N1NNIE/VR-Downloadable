using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public OVRPlayerController ovrPlayer;
    public bool godMode = false;
    public float health = 100;
    public float damage = 0;
    public GameObject[] enemies;

    void Start()
    {
        

    }

    void Update()
    {
        
    }

    public void EnableGodMode()
    {
        godMode = true;
    }

    public void DisableGodMode()
    {
        godMode = false;
    }

    public void KillAll()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
