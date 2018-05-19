using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    #region Singleton

    public static TextBoxManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public List<string> dialogueLines = new List<string>();
    public string speakerName;

    public GameObject dialoguePanel;
    public Button continueButton;
    public Text dialogueText;
    public Text nameText;

    int dialogueIndex;

    private void Start()
    {
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        dialoguePanel.GetComponent<Animator>().SetBool("Opened", false);
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);
        speakerName = npcName;

        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = speakerName;
        dialoguePanel.GetComponent<Animator>().SetBool("Opened", true);
        GameManager.instance.playerManager.playerMovement.CanMove(false);
    }

    public void ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.GetComponent<Animator>().SetBool("Opened", false);
            GameManager.instance.playerManager.playerMovement.CanMove(true);
        }
    }
}
