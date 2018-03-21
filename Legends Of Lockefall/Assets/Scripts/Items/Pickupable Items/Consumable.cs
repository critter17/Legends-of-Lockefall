using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ConsumableType { Heal, Magic, AttackBoost };

[CreateAssetMenu(fileName = "Consumable", menuName = "Items/Consumable")]
public class Consumable : Item {
    public int consumeAmount;
    public ConsumableType consumableType;

	public override void ItemAction(GameObject player)
    {
        switch(consumableType)
        {
            case ConsumableType.Heal:
                player.GetComponent<PlayerHealthManager>().Heal(consumeAmount);
                break;

            case ConsumableType.Magic:
                // Replenish magic
                break;

            case ConsumableType.AttackBoost:
                // Boost attack power
                player.GetComponent<HeroStatManager>().heroStats.baseStrength += consumeAmount;
                break;
        }
    }
}
