using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleSlot : ItemSlot {

    public Edible edible;

    private void Start()
    {
        
    }

    public void AddEdible(Edible newEdible)
    {
        edible = newEdible;
        icon.sprite = edible.itemSprite;
        icon.enabled = true;

        Debug.Log("Mouse position: " + Input.mousePosition);
        Debug.Log("Item position: " + this.transform.position);
    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        edible = null;
    }

    public void EatEdible()
    {
        edible.InventoryItemAction();
    }
}
