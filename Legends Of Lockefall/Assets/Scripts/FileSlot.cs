using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileSlot : MonoBehaviour {
    public GameObject fileSelectPanel;
    public GameObject characterStatsPanel;

    public GameFileData gameData;
    public Button newGameButton;
    public Button startGameButton;
    public GameObject eraseButton;
    public Text fileName;
    public Text currencyText;
    public Image characterSprite;
    public Sprite[] characterSprites;

    private void Awake()
    {
        DeactivateFileSlot();
    }

    private void OnEnable()
    {
        SetupFileSlot();
    }

    private void OnDisable()
    {
        DeactivateFileSlot();
    }

    public void SetupFileSlot()
    {
        if(gameData.isNewGame)
        {
            newGameButton.gameObject.SetActive(true);
            startGameButton.gameObject.SetActive(false);
            characterSprite.enabled = false;
        }
        else
        {
            startGameButton.gameObject.SetActive(true);
            newGameButton.gameObject.SetActive(false);
            characterSprite.enabled = true;
            Debug.Log("Sprite Index: " + gameData.spriteIndex);
            if(gameData.spriteIndex >= 0) characterSprite.sprite = characterSprites[gameData.spriteIndex];
        }

        fileName.text = gameData.fileName;
        currencyText.text = gameData.currency.ToString();
    }

    public void DeactivateFileSlot()
    {
        newGameButton.gameObject.SetActive(false);
        startGameButton.gameObject.SetActive(false);
        characterSprite.enabled = false;
        eraseButton.SetActive(false);
    }

    public void EraseFileInfo()
    {
        characterSprite.sprite = null;
        gameData.EraseInfo();
    }

    public void OnEraseButton(int fileToErase)
    {
        SaveLoad.Erase(fileToErase);
        EraseFileInfo();
        SetupFileSlot();
        fileSelectPanel.GetComponent<FileSelect>().ToggleEraseButtons();
    }

    public void OnNewFileButton(int gameToSave)
    {
        GameManager.instance.fileId = gameToSave;
        GameManager.instance.gameData = gameData;
        characterStatsPanel.SetActive(true);
        fileSelectPanel.SetActive(false);
    }

    public void OnStartGameButton(int gameToLoad)
    {
        GameManager.instance.fileId = gameToLoad;
        GameManager.instance.gameData = gameData;
        GameManager.instance.LoadGame();
    }
}
