using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Disposable")]
public class Disposable : Item {

    public override void ItemPickup()
    {
        PlayerInventory.instance.disposableInventory.AddDisposable(this);
    }
}
