using System.Collections;
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
    }

    #endregion

    public GameObject player;
    public Text currencyText;
    public int totalCurrency;

    public List<Interactable> interactablesInRange = new List<Interactable>();

    public delegate void OnEnemyKilled(string EnemyName); // I'm just putting it here because I can.
    public OnEnemyKilled OnEnemyKilledCallback;

    private void Start()
    {
        OnEnemyKilledCallback += Filler;
    }

    private void Update()
    {
        currencyText.text = totalCurrency.ToString();

        if(Input.GetButtonDown("Fire2"))
        {
            if(interactablesInRange[0] != null)
            {
                interactablesInRange[0].Interact();
            }
        }
    }

    void Filler(string filler)
    {
        //this is only here to make sure OnEnemyKilledCombat stays active.
    }
}
