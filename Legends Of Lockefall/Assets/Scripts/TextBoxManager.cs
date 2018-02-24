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

    public GameObject textBox;

    public Text text;

    public string speakerName;
    public Text speakerNameText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;
	
	void Update ()
    {
        if(textFile != null)
        {
            OpenTextBox();
            text.text = textLines[currentLine];
            speakerNameText.text = speakerName;
        }
    }

    public void NextLine()
    {
        if (currentLine < endAtLine)
        {
            currentLine += 1;
        }
        else
        {
            CloseTextBox();
        }
    }

    public void CloseTextBox()
    {
        textBox.GetComponent<Animator>().SetBool("Opened", false);
        PlayerManager.instance.player.GetComponent<PlayerController>().CanMove(true);
        textFile = null;
        speakerName = "";
        currentLine = 0;
    }

    public void OpenTextBox()
    {
        textBox.GetComponent<Animator>().SetBool("Opened", true);
        PlayerManager.instance.player.GetComponent<PlayerController>().CanMove(false);
        UpdateTextBox();
    }

    public void UpdateTextBox()
    {
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        endAtLine = textLines.Length - 1;
    }
}
