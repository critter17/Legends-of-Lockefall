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
            CheckQuest();
        }
        else if(AssignedQuest && Helped)
        {

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
