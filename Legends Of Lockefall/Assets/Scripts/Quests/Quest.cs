using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour {

    public List<Goal> Goals { get; set; } = new List<Goal>();
    public string QuestName { get; set; }
    public string Description { get; set; }
    public int ExperienceReward { get; set; }
    public bool Completed { get; set; }
    public int completedGoals;

    public void CheckGoals()
    {
        if(completedGoals == Goals.Count)
        {
            Completed = true;
        }
    }

    public void GiveReward()
    {
        //do the things that are supposed to happen
        Debug.Log("Completed " + QuestName);
    }
}
