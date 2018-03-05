using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {
    public bool destroyOnInteract;

    public virtual void Interact()
    {
        if(destroyOnInteract)
        {
            Debug.Log("Destroying item...");
            Destroy(gameObject);
        }
    }
}
