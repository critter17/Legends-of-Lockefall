using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    #region Singleton
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
    }
    #endregion

    public int fileId;

    public IGameState gameState;

    public Text currencyText;
    public int currency = 0;

    public GameObject hud;
    public PlayerManager playerManager;
    public TextBoxManager textBoxManager;
    public QuestManager questManager;
    public GameFileData gameData;
    public GameObject[] characterObjects;

    private void Start()
    {
        gameState = new GameState();
    }

    private void Update()
    {
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
        textBoxManager.gameObject.SetActive(true);
        questManager.gameObject.SetActive(true);
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
        SceneManager.LoadScene("TestingSandbox");
        hud.SetActive(true);
        textBoxManager.gameObject.SetActive(true);
        questManager.gameObject.SetActive(true);
        GameFileData fileData = SaveLoad.Load(fileId);
        currency = fileData.currency;
        InitPlayer(characterObjects[fileData.playerIndex]);
    }

    public void InitPlayer(GameObject character)
    {
        playerManager.player = Instantiate(character);
        playerManager.player.transform.SetParent(transform);
        playerManager.Setup();
        playerManager.player.SetActive(true);
        playerManager.playerInventory.gameObject.SetActive(true);
    }
}
