using UnityEngine;

public enum EdibleType { Health, Magic, AttackBoost };

[CreateAssetMenu(fileName = "New Edible", menuName = "Items/Edible")]
public class Edible : Item {
    public EdibleType edibleType;
    public int edibleAmount;

	public override void ItemPickup()
    {
        PlayerInventory.instance.edibleInventory.AddEdible(this);
    }
}
