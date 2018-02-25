using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : Interactable {

    public int currencyAmount;

    public override void Interact()
    {
        base.Interact();
        PlayerManager.instance.totalCurrency += currencyAmount;
        Debug.Log(PlayerManager.instance.totalCurrency);
        Destroy(this.gameObject);
    }
}
