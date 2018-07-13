using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArmorInventory : InventoryBase {
    public GameObject armorSlotPrefab;
    public ArmorSlot[] armorSlots;

    private void OnEnable()
    {
        armorSlots = new ArmorSlot[maxQuantity];

        for(int i = 0; i < maxQuantity; i++)
        {
            GameObject itemSlot = Instantiate(armorSlotPrefab);
            itemSlot.name = "Armor Slot";
            itemSlot.transform.SetParent(slotsParent);
            itemSlot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            itemSlot.SetActive(true);
            armorSlots[i] = itemSlot.GetComponent<ArmorSlot>();
            armorSlots[i].SetSlotNum(i);
            armorSlots[i].ClearSlot();
        }
    }

    private void OnDisable()
    {
        for(int i = 0; i < maxQuantity; i++)
        {
            Destroy(armorSlots[i].gameObject);
        }
        armorSlots = null;
        currentSize = 0;
    }

    public void AddArmor(Armor newArmor)
    {
        bool isNew = CheckInventory(newArmor);

        if(isNew && currentSize < armorSlots.Length)
        {
            armorSlots[currentSize].AddArmor(newArmor);
            armorSlots[currentSize++].quantity += 1;
        }
    }

    private bool CheckInventory(Armor newArmor)
    {
        for(int i = 0; i < currentSize; i++)
        {
            // Check if the new weapon is the same as a weapon already in your inventory
            if(armorSlots[i].armor.itemName.Equals(newArmor.itemName))
            {
                // Check if adding the new item exceeds max quantity of the same item
                if(armorSlots[i].quantity + 1 <= maxQuantity)
                {
                    armorSlots[i].quantity += 1;
                    armorSlots[i].UpdateQuantity();
                    return false;
                }
            }
        }

        return true;
    }

    public void RemoveWeapon(Weapon weaponToRemove)
    {

    }
}
