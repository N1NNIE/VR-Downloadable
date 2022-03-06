using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingCustomObjects : MonoBehaviour
{
    public Transform customTransformLeft;
    public Transform customTransformRight;
    public float rotationX;
    public float rotationY;
    public float rotationZ;
    public GameObject debugger;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<OVRGrabber>())
        {
            //Input Getdown

            debugger.SetActive(true);

            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
            {
                this.transform.position = customTransformLeft.transform.position;
                this.customTransformLeft.parent = customTransformRight.transform;
                this.transform.rotation = new Quaternion(rotationX, rotationY, rotationZ, 0);
            }

            if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
            {
                this.transform.position = customTransformRight.transform.position;
                this.customTransformLeft.parent = customTransformRight.transform;
                this.transform.rotation = new Quaternion(rotationX, rotationY, rotationZ, 0);
            }

            //Input Getup

            if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger))
            {
                this.customTransformLeft.parent = null;
            }

            if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
            {
                this.customTransformLeft.parent = null;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        var hand = other.GetComponent<OVRGrabber>();

        if (hand)
        {
            debugger.SetActive(false);
            this.customTransformLeft.parent = null;
        }
    }
}
