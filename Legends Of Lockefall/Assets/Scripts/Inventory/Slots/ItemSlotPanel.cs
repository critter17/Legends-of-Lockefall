using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotPanel : MonoBehaviour {
    public InventoryUI inventoryUI;
    public ItemSlot[] itemSlots;
    public int lastSelectedSlot = 0;
    public bool currentTabUsed = false;

    private void Start()
    {

    }

    private void OnEnable()
    {
        itemSlots = GetComponentsInChildren<ItemSlot>();
        if(currentTabUsed)
        {
            itemSlots[inventoryUI.lastSelectedSlotIndex].slotSelected = true;
            for(int i = 0; i < itemSlots.Length; i++)
            {
                itemSlots[i].itemButton.enabled = true;
            }
        }
        else
        {
            for(int i = 0; i < itemSlots.Length; i++)
            {
                itemSlots[i].slotSelected = false;
                itemSlots[i].itemButton.enabled = false;
            }
        }
    }

    public void SlotButtonToggle(bool enableToggle)
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject);
        if(EventSystem.current.currentSelectedGameObject != null)
        {
            inventoryUI.lastSelectedSlotIndex = EventSystem.current.currentSelectedGameObject.GetComponent<ItemSlot>().slotNumber;
            EventSystem.current.SetSelectedGameObject(null);
        }

        ChangeSlotEnabled(enableToggle);

        if(enableToggle == true)
        {
            EventSystem.current.SetSelectedGameObject(itemSlots[inventoryUI.lastSelectedSlotIndex].gameObject);
        }
    }

    public void ChangeSlotEnabled(bool enableToggle)
    {
        for(int i = 0; i < itemSlots.Length; i++)
        {
            itemSlots[i].itemButton.enabled = enableToggle;

        }
    }

    public void SetCurrentGameObject(int index)
    {
        //itemSlots[index].slotSelected = true;
        EventSystem.current.SetSelectedGameObject(itemSlots[index].gameObject);
    }
}
