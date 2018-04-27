using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour {
    public GameObject characterStatsPanel;
    public GameObject titlePanel;
    public GameObject fileSelectPanel;

    private void Awake()
    {
        characterStatsPanel.SetActive(false);
        titlePanel.SetActive(true);
        fileSelectPanel.SetActive(false);
    }

    private void Update()
    {
        if(Input.anyKeyDown)
        {
            if(titlePanel.activeSelf)
            {
                fileSelectPanel.SetActive(true);
                titlePanel.SetActive(false);
            }      
        }
    }

    public void OnNewFileButton(int gameToSave)
    {
        GameManager.instance.fileId = gameToSave;
        GameManager.SaveGame();
        characterStatsPanel.SetActive(true);
        fileSelectPanel.SetActive(false);
    }

    public void OnStartGameButton(int gameToLoad)
    {
        GameManager.instance.fileId = gameToLoad;
        GameManager.LoadGame();
    }
}
