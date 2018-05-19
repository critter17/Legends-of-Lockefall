using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameFileData {
    public int playerIndex;
    public int spriteIndex;
    public string fileName;
    public bool isNewGame;
    public int currentHealth;
    public int maxHealth;
    public int currency;

    public GameFileData()
    {
        spriteIndex = -1;
        fileName = "New File";
        isNewGame = true;
        currentHealth = 0;
        maxHealth = 0;
        currency = 0;
    }

    public GameFileData(GameManager gameManager)
    {
        currency = gameManager.currency;
    }

    public void EraseInfo()
    {
        Debug.Log("Erasing File Info");
        fileName = "New File";
        isNewGame = true;
        currentHealth = 0;
        maxHealth = 0;
        currency = 0;
    }
}
