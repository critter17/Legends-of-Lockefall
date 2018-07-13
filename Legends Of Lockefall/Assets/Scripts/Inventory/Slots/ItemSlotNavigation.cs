using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotNavigation : MonoBehaviour {

    public ItemSlot itemSlot;
    public ItemSlotPanel itemSlotPanel;
    public InventoryUI inventoryUI;

    private void OnEnable()
    {
        if(itemSlot.slotSelected && itemSlot.itemButton.enabled)
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(itemSlot.itemButton.gameObject);
        }

        itemSlotPanel = itemSlot.GetComponentInParent<ItemSlotPanel>();
        inventoryUI = FindObjectOfType<InventoryUI>();
    }

    private void OnDisable()
    {
        itemSlot.slotSelected = false;
    }
}
