using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    #region Singleton

    public static PlayerManager instance;
    public GameObject[] characterList;
    private int selectedCharacterIndex;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    #endregion

    public GameObject player;
    public PlayerInventory playerInventory;

    public delegate void OnEnemyKilled(string EnemyName); // I'm just putting it here because I can.
    public OnEnemyKilled OnEnemyKilledCallback;


    private void Start()
    {
        OnEnemyKilledCallback += Filler;
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            selectedCharacterIndex = PlayerPrefs.GetInt("CharacterSelected");
            player = Instantiate(characterList[selectedCharacterIndex]);
            for(int i = 0; i < characterList.Length; i++)
            {
                if(i != selectedCharacterIndex)
                {
                    characterList[i].SetActive(false);
                }
            }
            player.transform.SetParent(transform);
            player.SetActive(true);
            playerInventory.gameObject.SetActive(true);
        }
    }

    private void Update()
    {

    }

    void Filler(string filler)
    {
        //this is only here to make sure OnEnemyKilledCombat stays active.
    }
}
