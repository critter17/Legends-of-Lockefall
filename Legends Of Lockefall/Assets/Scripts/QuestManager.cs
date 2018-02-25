using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour {

    #region Singleton

    public static QuestManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than one instance of QuestManager detected");
        }
    }

    #endregion

    public Quest[] allQuests;
    public Quest activeQuest;
    public Goal activeGoal;
    public int activeQuestIndex;

    public GameObject questPanel;
    public Text questName;
    public Text goalDescription;
    
	void Start ()
    {
        activeQuestIndex = 0;
        UpdateAllQuests();
	}
	
	void Update ()
    {
		if(activeQuest != null)
        {
            activeGoal = activeQuest.Goals[0];
            questName.text = activeQuest.QuestName;
            if (!activeQuest.Completed)
            {
                goalDescription.text = activeGoal.Description;
            }
            else
            {
                goalDescription.text = "Return to quest giver";
            }
        }

        if(allQuests.Length != 0)
        {
            activeQuest = allQuests[activeQuestIndex];
            if(Input.GetButtonDown("SwtichActiveQuest"))
            {
                activeQuestIndex += 1;
            }
        }

        if(activeQuestIndex == allQuests.Length)
        {
            activeQuestIndex = 0;
        }
	}

    public void UpdateAllQuests()
    {
        allQuests = GetComponents<Quest>();
        if(allQuests.Length == 0)
        {
            questPanel.SetActive(false);
        }
        else
        {
            questPanel.SetActive(true);
        }
    }
}
