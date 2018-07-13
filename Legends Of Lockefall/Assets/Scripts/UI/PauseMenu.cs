using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

    private PlayerController playerMovement;
    public GameObject buttonList;
    public Button resumeButton;
    public Button settingsButton;
    public Button mainMenuButton;

    private void Start()
    {
        playerMovement = GameManager.instance.playerManager.playerMovement;
    }

    private void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if(playerMovement.canMove)
            {
                buttonList.SetActive(true);
                playerMovement.CanMove(false);
                EventSystem.current.SetSelectedGameObject(resumeButton.gameObject);
            }
            else
            {
                buttonList.SetActive(false);
                playerMovement.CanMove(true);
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }

    public void Resume()
    {
        playerMovement.CanMove(true);
        buttonList.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Settings()
    {
        // Opens Settings Menu
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(GameManager.instance.playerManager.player);

        buttonList.SetActive(false);
        GameManager.instance.playerManager.playerInventory.gameObject.SetActive(false);
        GameManager.instance.textBoxManager.gameObject.SetActive(false);
        GameManager.instance.questManager.gameObject.SetActive(false);
        GameManager.instance.hud.SetActive(false);
        GameManager.instance.playerManager.playerInventory.gameObject.SetActive(false);
    }
}
