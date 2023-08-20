using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour
{
    public Vector3 force;
    private List<Rigidbody> effectedObjects = new List<Rigidbody>();

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            effectedObjects.Add(rb);

        DestroyableMonoBehavior destroyable = other.GetComponent<DestroyableMonoBehavior>();
        if (destroyable != null)
            destroyable.OnDestroyEvent += () => effectedObjects.Remove(rb);
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            effectedObjects.Remove(rb);

        DestroyableMonoBehavior destroyable = other.GetComponent<DestroyableMonoBehavior>();
        if (destroyable != null)
            destroyable.OnDestroyEvent += () => effectedObjects.Remove(rb);
    }

    public void FixedUpdate()
    {
        foreach (var rb in effectedObjects)
        {
            rb.AddForce(force);
        }
    }
}
