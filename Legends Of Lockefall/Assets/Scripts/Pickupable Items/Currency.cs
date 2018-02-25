using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : PickupableObject {
    public int currencyAmount;
    public bool once = false;

    public override void Pickup()
    {
        PlayerManager.instance.totalCurrency += currencyAmount;
        Debug.Log(PlayerManager.instance.totalCurrency);
        Kill();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!once)
        {
            Pickup();
            once = true;
        }
    }
}
