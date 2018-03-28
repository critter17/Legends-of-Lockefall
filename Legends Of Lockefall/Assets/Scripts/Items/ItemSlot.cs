using UnityEngine.UI;
using UnityEngine;

public abstract class ItemSlot : MonoBehaviour {

    public Image icon;
    public Text numItemsInSlot;
    public int maxItems;

    public abstract void ClearSlot();
}
