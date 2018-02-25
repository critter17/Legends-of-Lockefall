using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float interactionRadius;
    public bool destroyOnInteract;
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        float distToPlayer = Vector3.Distance(PlayerManager.instance.player.transform.position, transform.position);
        if (distToPlayer <= interactionRadius)
        {
            if (!PlayerManager.instance.interactablesInRange.Contains(this))
                PlayerManager.instance.interactablesInRange.Add(this);
        }
        else
        {
            if(PlayerManager.instance.interactablesInRange.Contains(this))
                PlayerManager.instance.interactablesInRange.Remove(this);
        }
    }

    public virtual void Interact()
    {
        if(destroyOnInteract)
        {
            if (PlayerManager.instance.interactablesInRange.Contains(this))
                PlayerManager.instance.interactablesInRange.Remove(this);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
