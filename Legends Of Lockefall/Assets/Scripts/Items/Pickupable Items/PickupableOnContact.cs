﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupableOnContact : MonoBehaviour {

    public abstract void Pickup(GameObject player);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Pickup(collision.gameObject);
        }
    }
}
