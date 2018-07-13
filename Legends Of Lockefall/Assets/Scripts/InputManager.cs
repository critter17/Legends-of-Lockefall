using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour {
    public InventoryUI inventoryUI;
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if(mouseX != 0 || mouseY != 0)
        {
            if(inventoryUI.gameObject.activeSelf == true)
            {
                EventSystem.current.SetSelectedGameObject(null);
                inventoryUI.lastSelectedSlotIndex = 0;
            }
        }

        if(horizontal != 0 || vertical != 0)
        {
            if(inventoryUI.gameObject.activeSelf == true && EventSystem.current.currentSelectedGameObject == null)
            {
                inventoryUI.SetGameObject();
            }
        }
    }
}
