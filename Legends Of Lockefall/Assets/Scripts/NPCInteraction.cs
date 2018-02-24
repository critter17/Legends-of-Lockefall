using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour {

    public TextAsset dialogue;
    public string NPCName;
    public float interactionRadius = 3;
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        float distToPlayer = Vector3.Distance(PlayerManager.instance.player.transform.position, transform.position);
        if(distToPlayer <= interactionRadius)
        {
            if(Input.GetButtonDown("Fire2"))
            {
                Interact();
            }
        }
	}

    public void Interact()
    {
        TextBoxManager.instance.textFile = dialogue;
        TextBoxManager.instance.speakerName = NPCName;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
