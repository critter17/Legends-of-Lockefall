using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    private PlayerController playerMovement;
    public GameObject buttonList;

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
            }
            else
            {
                buttonList.SetActive(false);
                playerMovement.CanMove(true);
            }
        }
    }

    public void Resume()
    {
        playerMovement.CanMove(true);
        buttonList.SetActive(false);
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
