using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileSlot : MonoBehaviour {
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
            characterSprite.enabled = false;
        }
        else
        {
            startGameButton.gameObject.SetActive(true);
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
    }
}
