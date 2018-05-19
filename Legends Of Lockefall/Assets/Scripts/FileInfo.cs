using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "FileSlotInfo", menuName = "File Slot")]
public class FileInfo : ScriptableObject {
    public string fileName = "New File";
    public bool isNewGame = true;
    public int currentHealth;
    public int maxHealth;
    public int currency;
    public GameObject player;
    public Sprite characterSprite;
    public Sprite scepterGemOne;
    public Sprite scepterGemTwo;
    public Sprite scepterGemThree;
    public Sprite scepterGemFour;
    public Sprite scepterGemFive;
    public Sprite scepterGemSix;

    public void EraseInfo()
    {
        Debug.Log("Erasing File Info");
        fileName = "New File";
        isNewGame = true;
        currentHealth = 0;
        maxHealth = 0;
        currency = 0;
        player = null;
        characterSprite = null;
        scepterGemOne = null;
        scepterGemTwo = null;
        scepterGemThree = null;
        scepterGemFour = null;
        scepterGemFive = null;
        scepterGemSix = null;
    }
}
