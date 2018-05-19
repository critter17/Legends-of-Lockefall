using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoal : Goal {

    public string EnemyName { get; set; }

    public KillGoal(Quest quest, string enemyName, string description, bool completed, int currentAmount, int requiredAmount)
    {
        Quest = quest;
        EnemyName = enemyName;
        Description = description;
        Completed = completed;
        CurrentAmount = currentAmount;
        RequiredAmount = requiredAmount;
    }

    public override void Init()
    {
        base.Init();
        GameManager.instance.playerManager.OnEnemyKilledCallback += EnemyDied;
    }

    void EnemyDied(string enemyName)
    {
        Debug.Log("Enemy died");
        if(enemyName.ToLower() == EnemyName.ToLower())
        {
            CurrentAmount++;
            Evaluate();
        }
    }
}
