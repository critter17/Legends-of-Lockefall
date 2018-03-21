using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Jewel", menuName = "Items/Currency")]
public class Currency : Item {
    public int currencyAmount = 0;

    public override void ItemAction(GameObject player)
    {
        PlayerManager.instance.totalCurrency += currencyAmount;
    }
}
