using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : Interactable {

    public TextAsset dialogue;
    public string NPCName;
    
    public override void Interact()
    {
        TextBoxManager.instance.textFile = dialogue;
        TextBoxManager.instance.speakerName = NPCName;
    }
}
