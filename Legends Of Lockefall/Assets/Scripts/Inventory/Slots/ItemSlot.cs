using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ItemSlot : MonoBehaviour {
    Item item;
    public Image icon;
    public Button itemButton;
    public Text quantityText;
    public int quantity;
    public GameObject selectCursorPrefab;
    private GameObject selectCursor;
    public int slotNumber;
    public bool slotSelected = false;

    public void UpdateQuantity()
    {
        if(quantity > 1)
        {
            quantityText.text = quantity.ToString();
            quantityText.enabled = true;
        }
        else
        {
            quantityText.text = null;
            quantityText.enabled = false;
        }
    }

    public virtual void AddItem(Item newItem)
    {

    }

    public virtual void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        //icon.enabled = false;
        quantityText.text = "0";
        quantityText.enabled = false;
        quantity = 0;
    }

    public void SetSlotNum(int num)
    {
        slotNumber = num;
    }

    public void SelectSlot()
    {
        selectCursor = Instantiate(selectCursorPrefab);
        selectCursor.transform.SetParent(transform);
        selectCursor.transform.localPosition = new Vector3(0.0f, 24.0f, 0.0f);
    }

    public void DeselectSlot()
    {
        Destroy(selectCursor);
    }
}
