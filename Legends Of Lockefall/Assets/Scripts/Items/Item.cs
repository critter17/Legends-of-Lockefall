using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Generic")]
public abstract class Item : ScriptableObject
{
    public GameObject itemGameObject;
    public string itemName = "New Item";
    public string itemDescription = "This item does something";
    public Sprite itemSprite = null;
    public int maxInventorySpace = 1;

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
