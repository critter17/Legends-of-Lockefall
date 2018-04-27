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

    public List<Quest> quests;

    private void Start()
    {

    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            hud.SetActive(false);
            playerManager.gameObject.SetActive(false);
            textBoxManager.gameObject.SetActive(false);
            questManager.gameObject.SetActive(false);
        }
        else
        {
            hud.SetActive(true);
            playerManager.gameObject.SetActive(true);
            textBoxManager.gameObject.SetActive(true);
            questManager.gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F5))
        {
            Debug.Log("Saving");
            //SaveGame();
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

    public static void SaveGame()
    {
        SaveLoad.Save(instance.fileId, instance);
    }

    public static void LoadGame()
    {
        GameFileData gameData = SaveLoad.Load(instance.fileId);
        instance.currency = gameData.currency;

        SceneManager.LoadScene("TestingSandbox");
    }
}
