using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {
    public abstract void Interact(GameObject player);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerInteractManager playerInteract = collision.GetComponent<PlayerInteractManager>();
            if(playerInteract != null)
            {
                playerInteract.SetFocus(this);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerInteractManager playerInteract = collision.GetComponent<PlayerInteractManager>();
            if(playerInteract != null)
            {
                playerInteract.LoseFocus(this);
            }
        }
    }
}
