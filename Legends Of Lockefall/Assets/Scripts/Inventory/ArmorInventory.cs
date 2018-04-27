using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ArmorInventory : InventoryBase {

    public ArmorSlot[] armorSlots;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            armorSlots = slotsParent.GetComponentsInChildren<ArmorSlot>();
            for(int i = 0; i < armorSlots.Length; i++)
            {
                armorSlots[i].ClearSlot();
            }
        }
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
