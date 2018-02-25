using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal {

    public Quest Quest { get; set; }
	public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }

    public virtual void Init()
    {

    }

    public void Evaluate()
    {
        if(CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        Debug.Log("Goal completed! return to quest giver");
        Quest.completedGoals += 1;
        Quest.CheckGoals();
        Completed = true;
    }
}
