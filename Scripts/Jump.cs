using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public OVRPlayerController player;

    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            AddForce(player.GetComponent<Rigidbody>());
        }
    }

    void AddForce(Rigidbody rb)
    {
        rb.velocity += new Vector3(0, player.JumpForce, 0);
    }
}
