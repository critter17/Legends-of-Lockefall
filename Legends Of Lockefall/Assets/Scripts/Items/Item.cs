using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Generic")]
public class Item : ScriptableObject {
    public string itemName = "New Item";
    public Sprite itemSprite = null;
    public bool isDefaultItem = false;
}
