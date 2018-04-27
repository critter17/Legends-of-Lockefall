using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorSlot : ItemSlot {

    public Armor armor;

    private void Start()
    {

    }

    public void AddArmor(Armor newArmor)
    {
        armor = newArmor;
        icon.sprite = armor.itemSprite;
        icon.enabled = true;
    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        armor = null;
    }

    public void SelectArmor()
    {
        armor.InventoryItemAction();
    }
}
