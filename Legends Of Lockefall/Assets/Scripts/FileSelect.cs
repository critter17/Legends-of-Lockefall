using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileSelect : MonoBehaviour {
    public Button copyButton;
    public Button eraseButton;
    public FileSlot[] fileSlots;
    public Sprite[] characterSprites;

    // Use this for initialization
    void Start () {
        for(int i = 0; i < 3; i++)
        {
            GameFileData game = SaveLoad.Load(i);
            if(game != null)
            {
                fileSlots[i].gameData = game;
            }
            else
            {
                fileSlots[i].gameData = new GameFileData();
            }
            fileSlots[i].SetupFileSlot();
        }
    }

    private void Update()
    {
        
    }

    public void OnCopyFile()
    {

    }

    public void OnEraseFile()
    {
        for(int i = 0; i < fileSlots.Length; i++)
        {
            fileSlots[i].eraseButton.SetActive(!fileSlots[i].eraseButton.activeSelf);
        }
    }
}
