using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EdibleInventory : InventoryBase {

    public EdibleSlot[] edibleSlots;

	// Use this for initialization
	void Start ()
    {
        
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            edibleSlots = slotsParent.GetComponentsInChildren<EdibleSlot>();
            for(int i = 0; i < edibleSlots.Length; i++)
            {
                edibleSlots[i].ClearSlot();
            }
        }
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
