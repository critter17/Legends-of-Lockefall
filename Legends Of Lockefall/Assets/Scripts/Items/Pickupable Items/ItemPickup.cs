using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : PickupableOnContact {
    public Item item;

    public override void Pickup(GameObject player)
    {
        item.ItemPickup();
        Destroy(gameObject);
    }
}
