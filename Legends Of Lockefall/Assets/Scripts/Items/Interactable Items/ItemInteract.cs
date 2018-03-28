using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : Interactable {
    public Item item;

    public override void Interact(GameObject player)
    {
        Debug.Log("Interacting with " + item.itemName);
        item.ItemInteract(player);
        if(PlayerInventory.instance.weaponList.Contains((Weapon)item))
            Destroy(this.gameObject);
    }
}
