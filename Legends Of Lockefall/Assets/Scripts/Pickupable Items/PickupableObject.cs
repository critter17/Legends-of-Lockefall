using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObject : MonoBehaviour {

    public virtual void Pickup()
    {
        Debug.Log("Pickup base class.");
    }

    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
