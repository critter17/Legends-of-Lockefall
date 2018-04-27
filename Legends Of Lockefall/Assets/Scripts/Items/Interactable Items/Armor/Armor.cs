using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Armor")]
public class Armor : Item {
    public int attackModifier;
    public int defenseModifier;
    public ElementType elementType;

    public override void ItemInteract(GameObject player)
    {
        PlayerInventory.instance.armorInventory.AddArmor(this);
    }
}
