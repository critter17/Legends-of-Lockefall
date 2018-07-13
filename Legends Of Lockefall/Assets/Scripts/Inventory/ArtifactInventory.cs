using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArtifactInventory : InventoryBase {
    public GameObject artifactSlotPrefab;
    public ArtifactSlot[] artifactSlots;

    private void OnEnable()
    {
        artifactSlots = new ArtifactSlot[maxQuantity];

        for(int i = 0; i < maxQuantity; i++)
        {
            GameObject itemSlot = Instantiate(artifactSlotPrefab);
            itemSlot.name = "Artifact Slot";
            itemSlot.transform.SetParent(slotsParent);
            itemSlot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            itemSlot.SetActive(true);
            artifactSlots[i] = itemSlot.GetComponent<ArtifactSlot>();
            artifactSlots[i].SetSlotNum(i);
            artifactSlots[i].ClearSlot();
        }
    }

    private void OnDisable()
    {
        for(int i = 0; i < maxQuantity; i++)
        {
            Destroy(artifactSlots[i].gameObject);
        }
        artifactSlots = null;
        currentSize = 0;
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
