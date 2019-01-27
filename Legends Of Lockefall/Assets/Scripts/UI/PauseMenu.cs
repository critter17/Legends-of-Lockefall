using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MenuSelectionHandler {

   //public PlayerController playerMovement;
    //public GameObject buttonList;
    public Button resumeButton;
    public Button settingsButton;
    public Button mainMenuButton;

    private void Start()
    {
        //playerMovement = GameManager.instance.playerManager.playerMovement;
        EventSystem.current.SetSelectedGameObject(resumeButton.gameObject);
    }

    private void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("Pause Menu");
        //playerMovement = GameManager.instance.playerManager.playerMovement;
    }

    private void OnDisable()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Resume()
    {
        GameManager.instance.TogglePause();
    }

    public void Settings()
    {
        // Opens Settings Menu
    }

    public void BackToMainMenu()
    {
        GameManager.instance.ReturnNoSave();
    }
}
