using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : Interactable {

    public string NPCName;
    public string[] dialogue;
    
    public override void Interact()
    {
        TextBoxManager.instance.AddNewDialogue(dialogue, NPCName);
    }
}
