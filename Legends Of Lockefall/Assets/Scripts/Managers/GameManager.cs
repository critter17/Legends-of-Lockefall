using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

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

        DontDestroyOnLoad(gameObject);

        Debug.Log("GameManager Awake");
    }

    public int fileId;

    public Text currencyText;
    public int currency = 0;

    public GameObject hud;
    public PlayerManager playerManager;
    public TextBoxManager textBoxManager;
    public QuestManager questManager;
    //public FileInfo fileInfo;
    public GameFileData gameData;
    public GameObject[] characterObjects;

    private void Start()
    {
        Debug.Log("GameManager Start");

        //Debug.Log("GameManager currency: " + currency);
        //Debug.Log("GameManager fileinfo: " + fileInfo);
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            //hud.SetActive(false);
            //playerManager.gameObject.SetActive(false);
            textBoxManager.gameObject.SetActive(false);
            questManager.gameObject.SetActive(false);
        }
        else
        {
            //hud.SetActive(true);
            //playerManager.gameObject.SetActive(true);
            textBoxManager.gameObject.SetActive(true);
            questManager.gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F5))
        {
            SaveGame();
        }

        if(Input.GetKeyDown(KeyCode.F9))
        {
            LoadGame();
        }

        if(currencyText != null)
        {
            currencyText.text = currency.ToString();
        }
    }

    public void SetupGame(int currentIndex, GameObject selectedCharacter)
    {
        hud.SetActive(true);
        InitPlayer(selectedCharacter);
        gameData.playerIndex = currentIndex;
        gameData.spriteIndex = currentIndex;
        gameData.isNewGame = false;
        SaveGame();
    }

    public void SaveGame()
    {
        gameData.currency = currency;
        SaveLoad.Save(fileId, gameData);
    }

    public void LoadGame()
    {
        instance.hud.SetActive(true);
        GameFileData fileData = SaveLoad.Load(fileId);
        currency = fileData.currency;
        InitPlayer(characterObjects[fileData.playerIndex]);
        SceneManager.LoadScene("TestingSandbox");
    }

    public void InitPlayer(GameObject character)
    {
        playerManager.player = Instantiate(character);
        playerManager.player.transform.SetParent(transform);
        playerManager.player.SetActive(true);
        playerManager.playerInventory.gameObject.SetActive(true);
        playerManager.Setup();
    }
}
