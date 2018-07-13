using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponInventory : InventoryBase {
    public GameObject weaponSlotPrefab;
    public WeaponSlot[] weaponSlots;

    private void OnEnable()
    {
        weaponSlots = new WeaponSlot[maxQuantity];

        for(int i = 0; i < maxQuantity; i++)
        {
            GameObject itemSlot = Instantiate(weaponSlotPrefab);
            itemSlot.name = "Weapon Slot";
            itemSlot.transform.SetParent(slotsParent);
            itemSlot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            itemSlot.SetActive(true);
            weaponSlots[i] = itemSlot.GetComponent<WeaponSlot>();
            weaponSlots[i].SetSlotNum(i);
            weaponSlots[i].ClearSlot();
        }
    }

    private void OnDisable()
    {
        for(int i = 0; i < maxQuantity; i++)
        {
            Destroy(weaponSlots[i].gameObject);
        }
        weaponSlots = null;
        currentSize = 0;
    }

    public void AddWeapon(Weapon newWeapon)
    {
        bool isNew = CheckInventory(newWeapon);

        if(isNew && currentSize < weaponSlots.Length)
        {
            weaponSlots[currentSize].AddWeapon(newWeapon);
            weaponSlots[currentSize++].quantity += 1;
        }
    }

    private bool CheckInventory(Weapon newWeapon)
    {
        for(int i = 0; i < currentSize; i++)
        {
            // Check if the new weapon is the same as a weapon already in your inventory
            if(weaponSlots[i].weapon.itemName.Equals(newWeapon.itemName))
            {
                // Check if adding the new item exceeds max quantity of the same item
                if(weaponSlots[i].quantity + 1 <= maxQuantity)
                {
                    weaponSlots[i].quantity += 1;
                    weaponSlots[i].UpdateQuantity();
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
