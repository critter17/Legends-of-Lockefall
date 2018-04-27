using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class WeaponInventory : InventoryBase {
    public WeaponSlot[] weaponSlots;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            weaponSlots = slotsParent.GetComponentsInChildren<WeaponSlot>();

            for(int i = 0; i < weaponSlots.Length; i++)
            {
                weaponSlots[i].ClearSlot();
            }
        }
    }

    private void OnDisable()
    {
        
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
