using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
        
    }

    public void OnPlaybutton()
    {
        if(titlePanel.activeSelf)
        {
            fileSelect.gameObject.SetActive(true);
            titlePanel.SetActive(false);
            EventSystem.current.SetSelectedGameObject(fileSelect.eraseButton.gameObject);
        }
    }

    public void OnQuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
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
