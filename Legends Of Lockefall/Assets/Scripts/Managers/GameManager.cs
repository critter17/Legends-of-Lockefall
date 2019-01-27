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

    public Text currencyText;
    public int currency = 0;

    public GameObject hud;
    public PlayerManager playerManager;
    public TextBoxManager textBoxManager;
    public QuestManager questManager;
    public QuickSlotManager quickSlotManager;
    public GameFileData gameData;
    public GameObject[] characterObjects;

    public GameObject pauseMenu;
    public GameObject pauseMenuPrefab;
    public bool Paused { get; set; }

    private void Start()
    {
        Paused = false;
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

    public void TogglePause()
    {
        Paused = !Paused;

        if(Paused)
        {
            Time.timeScale = 0;
            playerManager.playerMovement.CanMove = false;

            // Instantiate Pause Menu
            pauseMenu = Instantiate(pauseMenuPrefab);
            pauseMenu.transform.SetParent(hud.transform);
        }
        else
        {
            Time.timeScale = 1;
            playerManager.playerMovement.CanMove = true;

            // Destroy Pause Menu
            Destroy(pauseMenu);
        }
    }

    public void SetupGame(int currentIndex, GameObject selectedCharacter)
    {
        InitPlayer(selectedCharacter);
        hud.SetActive(true);
        textBoxManager.gameObject.SetActive(true);
        questManager.gameObject.SetActive(true);
        quickSlotManager.gameObject.SetActive(true);
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
        GameFileData fileData = SaveLoad.Load(fileId);
        currency = fileData.currency;
        InitPlayer(characterObjects[fileData.playerIndex]);
        hud.SetActive(true);
        textBoxManager.gameObject.SetActive(true);
        questManager.gameObject.SetActive(true);
        quickSlotManager.gameObject.SetActive(true);
    }

    public void InitPlayer(GameObject character)
    {
        playerManager.player = Instantiate(character);
        playerManager.player.transform.SetParent(transform);
        playerManager.Setup();
        playerManager.player.SetActive(true);
        playerManager.playerInventory.gameObject.SetActive(true);
    }

    public void ReturnNoSave()
    {
        TogglePause();
        SceneManager.LoadScene("MainMenu");
        currency = 0;
        textBoxManager.gameObject.SetActive(false);
        questManager.gameObject.SetActive(false);
        quickSlotManager.gameObject.SetActive(false);
        hud.SetActive(false);
        playerManager.player.GetComponent<PlayerHealthManager>().heartsParent.Unsubscribe();
        Destroy(playerManager.player);
        playerManager.player = null;
        playerManager.playerStats = null;
        playerManager.playerInventory.gameObject.SetActive(false);
    }
}
