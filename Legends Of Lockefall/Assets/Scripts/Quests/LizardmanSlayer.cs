using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardmanSlayer : Quest {
    
	void Start ()
    {
        QuestName = "Lizardman Slayer";
        Description = "Kill 2 Lizardmen";

        Goals.Add(new KillGoal(this, "Lizardman", "Kill 5 Lizardmen", false, 0, 2));

        Goals.ForEach(g => g.Init());
	}
}
