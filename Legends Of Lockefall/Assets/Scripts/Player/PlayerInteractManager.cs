using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractManager : MonoBehaviour {

    public List<Interactable> focus;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2"))
        {
            if(focus.Count > 0)
            {
                Debug.Log("Interacting...");
                focus[focus.Count - 1].Interact(gameObject);
            }
        }
	}
    
    public void SetFocus(Interactable newFocus)
    {
        if(!focus.Contains(newFocus))
        {
            focus.Add(newFocus);
        }
    }

    public void LoseFocus(Interactable lostFocus)
    {
        if(focus.Contains(lostFocus))
        {
            focus.Remove(lostFocus);
        }
    }
}
