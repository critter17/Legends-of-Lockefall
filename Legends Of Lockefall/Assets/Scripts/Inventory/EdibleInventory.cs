using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EdibleInventory : InventoryBase {
    public GameObject edibleSlotPrefab;
    public EdibleSlot[] edibleSlots;

    private void OnEnable()
    {
        edibleSlots = new EdibleSlot[maxQuantity];

        for(int i = 0; i < maxQuantity; i++)
        {
            GameObject itemSlot = Instantiate(edibleSlotPrefab);
            itemSlot.name = "Edible Slot";
            itemSlot.transform.SetParent(slotsParent);
            itemSlot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            itemSlot.SetActive(true);
            edibleSlots[i] = itemSlot.GetComponent<EdibleSlot>();
            edibleSlots[i].SetSlotNum(i);
            edibleSlots[i].ClearSlot();
        }
    }

    private void OnDisable()
    {
        for(int i = 0; i < maxQuantity; i++)
        {
            Destroy(edibleSlots[i].gameObject);
        }
        edibleSlots = null;
        currentSize = 0;
    }

    public void AddEdible(Edible newEdible)
    {
        bool isNew = CheckInventory(newEdible);

        if(isNew && currentSize < edibleSlots.Length)
        {
            edibleSlots[currentSize].AddEdible(newEdible);
            edibleSlots[currentSize++].quantity += 1;
        }
    }

    private bool CheckInventory(Edible newEdible)
    {
        for(int i = 0; i < currentSize; i++)
        {
            // Check if the new weapon is the same as a weapon already in your inventory
            if(edibleSlots[i].edible.itemName.Equals(newEdible.itemName))
            {
                // Check if adding the new item exceeds max quantity of the same item
                if(edibleSlots[i].quantity + 1 <= maxQuantity)
                {
                    edibleSlots[i].quantity += 1;
                    edibleSlots[i].UpdateQuantity();
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
