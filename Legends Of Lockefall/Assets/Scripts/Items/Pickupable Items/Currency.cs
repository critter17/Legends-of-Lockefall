using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gem", menuName = "Item/Currency")]
public class Currency : Item
{
    public int currencyAmount;
    /*
    public override void Pickup()
    {
        PlayerManager.instance.totalCurrency += currencyAmount;
        Debug.Log(PlayerManager.instance.totalCurrency);
        Destroy(this.gameObject);
    }
    */
}
