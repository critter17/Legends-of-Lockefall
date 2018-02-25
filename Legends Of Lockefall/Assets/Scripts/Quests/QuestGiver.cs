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

    public string[] waitingDialogue;
    public string[] completionDialogue;
    public string[] finishedDialogue;

    public override void Interact()
    {
        if(!AssignedQuest && !Helped)
        {
            base.Interact();
            AssignQuest();
        }else if(AssignedQuest && !Helped)
        {
            TextBoxManager.instance.AddNewDialogue(waitingDialogue, NPCName);
            CheckQuest();
        }
        else if(AssignedQuest && Helped)
        {
            TextBoxManager.instance.AddNewDialogue(finishedDialogue, NPCName);
        }
    }

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)questGameObject.AddComponent(System.Type.GetType(questType));
        QuestManager.instance.UpdateAllQuests();
    }

    void CheckQuest()
    {
        if (Quest.Completed)
        {
            TextBoxManager.instance.AddNewDialogue(completionDialogue, NPCName);
            Quest.GiveReward();
            Helped = true;
            RemoveQuest();
        }
    }

    void RemoveQuest()
    {
        Destroy(questGameObject.GetComponent<Quest>());
        QuestManager.instance.UpdateAllQuests();
    }
}
