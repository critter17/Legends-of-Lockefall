using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : PickupableObject {

    public int currencyAmount;

    public override void Pickup()
    {
        PlayerManager.instance.totalCurrency += currencyAmount;
        Debug.Log(PlayerManager.instance.totalCurrency);
        Destroy(this.gameObject);
        Kill();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Pickup();
        }

    }
}
