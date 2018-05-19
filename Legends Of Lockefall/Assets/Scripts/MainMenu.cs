using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour {
    public GameObject characterStatsPanel;
    public GameObject titlePanel;
    public FileSelect fileSelect;

    private void Awake()
    {
        titlePanel.SetActive(true);
        characterStatsPanel.SetActive(false);
        fileSelect.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.anyKeyDown)
        {
            if(titlePanel.activeSelf)
            {
                fileSelect.gameObject.SetActive(true);
                titlePanel.SetActive(false);
            }      
        }
    }

    public void OnNewFileButton(int gameToSave)
    {
        GameManager.instance.fileId = gameToSave;
        GameManager.instance.gameData = fileSelect.fileSlots[gameToSave].gameData;
        characterStatsPanel.SetActive(true);
        fileSelect.gameObject.SetActive(false);
    }

    public void OnStartGameButton(int gameToLoad)
    {
        GameManager.instance.fileId = gameToLoad;
        GameManager.instance.gameData = fileSelect.fileSlots[gameToLoad].gameData;
        GameManager.instance.LoadGame();
    }
}
