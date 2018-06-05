using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposableInventory : InventoryBase {
    public GameObject disposableSlotPrefab;
    public DisposableSlot[] disposableSlots;

    private void OnEnable()
    {
        disposableSlots = new DisposableSlot[maxQuantity];
        for(int i = 0; i < maxQuantity; i++)
        {
            GameObject itemSlot = Instantiate(disposableSlotPrefab);
            itemSlot.name = "Disposable Slot";
            itemSlot.transform.SetParent(slotsParent);
            itemSlot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            itemSlot.SetActive(true);
            disposableSlots[i] = itemSlot.GetComponent<DisposableSlot>();
            disposableSlots[i].ClearSlot();
        }
    }

    public void AddDisposable(Disposable newDisposable)
    {
        bool isNew = CheckInventory(newDisposable);

        if(isNew && currentSize < disposableSlots.Length)
        {
            disposableSlots[currentSize].AddDisposable(newDisposable);
            disposableSlots[currentSize++].quantity += 1;
        }
    }

    private bool CheckInventory(Disposable newDisposable)
    {
        for(int i = 0; i < currentSize; i++)
        {
            // Check if the new weapon is the same as a weapon already in your inventory
            if(disposableSlots[i].disposable.itemName.Equals(newDisposable.itemName))
            {
                // Check if adding the new item exceeds max quantity of the same item
                if(disposableSlots[i].quantity + 1 <= maxQuantity)
                {
                    disposableSlots[i].quantity += 1;
                    disposableSlots[i].UpdateQuantity();
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
