using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtifactInventory : InventoryBase {

    public ArtifactSlot[] artifactSlots;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            artifactSlots = slotsParent.GetComponentsInChildren<ArtifactSlot>();
            for(int i = 0; i < artifactSlots.Length; i++)
            {
                artifactSlots[i].ClearSlot();
            }
        }
    }

    public void AddArtifact(Artifact newArtifact)
    {
        Debug.Log("Adding artifact...");
        bool isNew = CheckInventory(newArtifact);

        if(isNew && currentSize < artifactSlots.Length)
        {
            artifactSlots[currentSize].AddArtifact(newArtifact);
            artifactSlots[currentSize++].quantity += 1;
            Debug.Log("Hey there");
        }
        else
        {
            Debug.Log("Current size: " + currentSize + "\nartifactSlots length: " + artifactSlots.Length);
        }
    }

    private bool CheckInventory(Artifact newArtifact)
    {
        for(int i = 0; i < currentSize; i++)
        {
            // Check if the new weapon is the same as a weapon already in your inventory
            if(artifactSlots[i].artifact.itemName.Equals(newArtifact.itemName))
            {
                // Check if adding the new item exceeds max quantity of the same item
                if(artifactSlots[i].quantity + 1 <= maxQuantity)
                {
                    artifactSlots[i].quantity += 1;
                    artifactSlots[i].UpdateQuantity();
                    Debug.Log("In Check Inventory");
                    return false;
                }
            }
        }
        Debug.Log("No item in inventory");
        return true;
    }

    public void RemoveWeapon(Weapon weaponToRemove)
    {

    }
}
