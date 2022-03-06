using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionForce : MonoBehaviour
{
    public GameObject Object;
    public float power = 10;
    public float radius = 5;
    public float upForce = 1;

    void OnValidate()
    {
        if (Object == null)
        {
            Object = this.gameObject;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        Detonate();
    }

    void Detonate()
    {
        Vector3 explosionPoisition = Object.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPoisition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPoisition, radius, upForce, ForceMode.Impulse);
            }
        }
    }
}
