using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingZone : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform gunPointLeft;
    public Transform gunPointRight;
    public bool fireLeft = false;
    public bool fireRight = false;
    public int ammoleft = 1;
    public int ammoright = 1;

    public bool isRight = false;
    public bool isLeft = false;

    void Update()
    {
        //Left

        if (fireLeft)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && ammoleft == 1)
            {
                ammoleft--;
                Rigidbody clone;
                clone = Instantiate(bullet, gunPointLeft.transform.position, gunPointLeft.transform.rotation);

                clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            }
        }

        if (isLeft)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
            {
                fireLeft = true;
            }
        }

        if (ammoleft == 0)
        {
            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
            {
                ammoleft = 1;
            }
        }

        //Right

        if (fireRight)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && ammoright == 1)
            {
                ammoright--;
                Rigidbody clone;
                clone = Instantiate(bullet, gunPointRight.transform.position, gunPointRight.transform.rotation);

                clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            }
        }

        if (isRight)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
            {
                fireRight = true;
            }
        }

        if (ammoright == 0)
        {
            if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
            {
                ammoright = 1;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            isLeft = true;
        }

        if (other.gameObject.tag == "RightHand")
        {
            isRight = true;
        }
    }  

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            isLeft = false;
        }

        if (other.gameObject.tag == "RightHand")
        {
            isRight = false;
        }
    }
}
