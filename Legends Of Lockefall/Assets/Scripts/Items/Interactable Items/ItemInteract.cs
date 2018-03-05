using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : Interactable {
    public Item item;

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Interacting with " + item.itemName);
    }
}
