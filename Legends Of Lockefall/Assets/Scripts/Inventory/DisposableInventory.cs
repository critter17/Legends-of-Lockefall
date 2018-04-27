using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DisposableInventory : InventoryBase {

    public DisposableSlot[] disposableSlots;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            disposableSlots = slotsParent.GetComponentsInChildren<DisposableSlot>();
            for(int i = 0; i < disposableSlots.Length; i++)
            {
                disposableSlots[i].ClearSlot();
            }
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
