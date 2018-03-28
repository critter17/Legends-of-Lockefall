using UnityEngine;

public enum EdibleType { Health, Magic, AttackBoost };

[CreateAssetMenu(fileName = "New Edible", menuName = "Items/Edible")]
public class Edible : Item {
    public int edibleAmount;
    public EdibleType edibleType;

	public override void ItemPickup()
    {
        
    }
}
