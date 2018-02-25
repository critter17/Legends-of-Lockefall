using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : NPCInteraction {

    public bool AssignedQuest { get; set; }
    public bool Helped { get; set; }

    [SerializeField]
    private GameObject questGameObject;
    public string questType;
    private Quest Quest { get; set; }

    public override void Interact()
    {
        if(!AssignedQuest && !Helped)
        {
            base.Interact();
            AssignQuest();
        }else if(AssignedQuest && !Helped)
        {
            TextBoxManager.instance.AddNewDialogue(new string[] { "Have you done what I asked?" }, NPCName);
            CheckQuest();
        }
        else if(AssignedQuest && Helped)
        {
            TextBoxManager.instance.AddNewDialogue(new string[] { "Thanks for doing that thing for me bro." }, NPCName);
        }
    }

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)questGameObject.AddComponent(System.Type.GetType(questType));
    }

    void CheckQuest()
    {
        if (Quest.Completed)
        {
            TextBoxManager.instance.AddNewDialogue(new string[] { "You did it! Thanks bro!" }, NPCName);
            Quest.GiveReward();
            Helped = true;
            RemoveQuest();
        }
    }

    void RemoveQuest()
    {
        Destroy(questGameObject.GetComponent<Quest>());
    }
}
