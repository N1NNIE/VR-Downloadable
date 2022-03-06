using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public List<GameObject> fractureCells;

    void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);

        for (int i = 0; i < fractureCells.Count; i++)
        {
            fractureCells[i].GetComponent<Rigidbody>().isKinematic = false;
            fractureCells[i].GetComponent<MeshCollider>().isTrigger = false;
            fractureCells[i].GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
