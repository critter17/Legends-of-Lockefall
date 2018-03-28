using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractManager : MonoBehaviour {

    public List<Interactable> focus;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2"))
        {
            if(focus.Count != 0)
            {
                focus[focus.Count - 1].Interact(this.gameObject);
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Interactable")
        {
            Interactable interactable = collision.GetComponent<Interactable>();
            if(!focus.Contains(interactable))
            {
                SetFocus(interactable);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Interactable")
        {
            Interactable interactable = collision.GetComponent<Interactable>();
            if(focus.Contains(interactable))
            {
                LoseFocus(interactable);
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        focus.Add(newFocus);
    }

    void LoseFocus(Interactable lostFocus)
    {
        focus.Remove(lostFocus);
    }
}
