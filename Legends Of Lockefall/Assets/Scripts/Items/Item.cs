using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Generic")]
public abstract class Item : ScriptableObject {
    public string itemName = "New Item";
    public Sprite itemSprite = null;
    public bool isDefaultItem = false;

    public virtual void ItemInteract(GameObject player)
    {
        Debug.Log("Interacting with " + itemName);
    }

    public virtual void ItemPickup()
    {
        Debug.Log("Picked up " + itemName);
    }

    public virtual void InventoryItemAction()
    {
        Debug.Log("Do some action with " + itemName);
    }
}
