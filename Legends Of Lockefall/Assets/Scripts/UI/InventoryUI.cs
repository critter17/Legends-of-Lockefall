using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MenuSelectionHandler {
    public ItemTabPanel[] itemTabPanels;
    [SerializeField] public int currentTabIndex = 0;
    [SerializeField] public int previousTabIndex = 0;
    public int lastSelectedSlotIndex = 0;

    // Update is called once per frame
    void Update () {
		if(Input.GetButtonDown("I_TabSwitchLeft") && currentTabIndex > 0)
        {
            previousTabIndex = currentTabIndex;
            itemTabPanels[--currentTabIndex].transform.SetAsLastSibling();
            SwitchCurrentTabPanel();
        }

        if(Input.GetButtonDown("I_TabSwitchRight") && currentTabIndex < (itemTabPanels.Length - 1))
        {
            previousTabIndex = currentTabIndex;
            itemTabPanels[++currentTabIndex].transform.SetAsLastSibling();
            SwitchCurrentTabPanel();
        }
	}

    public void OnTabChange(int tabToChangeTo)
    {
        previousTabIndex = currentTabIndex;
        itemTabPanels[tabToChangeTo].transform.SetAsLastSibling();
        currentTabIndex = tabToChangeTo;
        itemTabPanels[previousTabIndex].itemSlotPanel.SlotButtonToggle(false);
        itemTabPanels[currentTabIndex].itemSlotPanel.SlotButtonToggle(true);
    }

    public void SwitchCurrentTabPanel()
    {
        itemTabPanels[previousTabIndex].itemSlotPanel.SlotButtonToggle(false);
        itemTabPanels[currentTabIndex].itemSlotPanel.SlotButtonToggle(true);
        itemTabPanels[currentTabIndex].itemSlotPanel.SetCurrentGameObject(lastSelectedSlotIndex);
    }

    public void SetGameObject()
    {
        itemTabPanels[currentTabIndex].itemSlotPanel.SetCurrentGameObject(lastSelectedSlotIndex);
    }

    private void OnEnable()
    {
        Debug.Log("Enabling Inventory UI");
        itemTabPanels[currentTabIndex].itemSlotPanel.currentTabUsed = true;
    }

    private void OnDisable()
    {
        Debug.Log("Disabling Inventory UI");
    }
}
