using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : PickupableOnContact {
    public Item item;
    [HideInInspector] public string itemName;

    private void Start()
    {
        itemName = item.itemName;
    }

    public override void Pickup(GameObject player)
    {
        Debug.Log("Picking up " + item.name);
        item.ItemAction(player);
        Destroy(gameObject);
    }
}
