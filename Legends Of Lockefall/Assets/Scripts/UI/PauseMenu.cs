using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

    public PlayerController playerMovement;
    public GameObject buttonList;
    public Button resumeButton;
    public Button settingsButton;
    public Button mainMenuButton;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if(Time.timeScale == 1)
            {
                buttonList.SetActive(true);
                playerMovement.CanMove(false);
                Time.timeScale = 0;
                EventSystem.current.SetSelectedGameObject(resumeButton.gameObject);
            }
            else
            {
                buttonList.SetActive(false);
                playerMovement.CanMove(true);
                Time.timeScale = 1;
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }

    private void OnEnable()
    {
        Debug.Log("Pause Menu");
        playerMovement = GameManager.instance.playerManager.playerMovement;
    }

    public void Resume()
    {
        playerMovement.CanMove(true);
        buttonList.SetActive(false);
        Time.timeScale = 1;
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Settings()
    {
        // Opens Settings Menu
    }

    public void BackToMainMenu()
    {
        buttonList.SetActive(false);
        GameManager.instance.ReturnNoSave();
    }
}
