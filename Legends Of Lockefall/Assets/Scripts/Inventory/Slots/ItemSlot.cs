using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class ItemSlot : MonoBehaviour {
    Item item;
    public Image icon;
    public Text quantityText;
    public int quantity;

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
        icon.sprite = null;
        icon.enabled = false;
    }
}
