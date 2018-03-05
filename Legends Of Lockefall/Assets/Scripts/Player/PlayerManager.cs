using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than one instance of PlayerManager detected");
        }

        theChar = FindObjectOfType<SelectCharacter>();
        for(int i = 0; i < theChar.transform.childCount; i++)
        {
            characterList.Add(theChar.transform.GetChild(i).gameObject);
        }

        selectedCharacterIndex = PlayerPrefs.GetInt("CharacterSelected");
        player = characterList[selectedCharacterIndex];
        for(int i = 0; i < characterList.Count; i++)
        {
            if(i != selectedCharacterIndex)
            {
                Destroy(characterList[i]);
            }
        }
        player.SetActive(true);
    }

    #endregion

    public SelectCharacter theChar;
    public GameObject player;
    public List<GameObject> characterList;
    private int selectedCharacterIndex;
    public Text currencyText;
    public int totalCurrency;

    public delegate void OnEnemyKilled(string EnemyName); // I'm just putting it here because I can.
    public OnEnemyKilled OnEnemyKilledCallback;


    private void Start()
    {
        OnEnemyKilledCallback += Filler;
    }

    private void Update()
    {
        currencyText.text = totalCurrency.ToString();
    }

    void Filler(string filler)
    {
        //this is only here to make sure OnEnemyKilledCombat stays active.
    }
}
