using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public delegate void OnEnemyKilled(string EnemyName); // I'm just putting it here because I can.
    public OnEnemyKilled OnEnemyKilledCallback;

    private void Start()
    {
        OnEnemyKilledCallback += filler;
    }

    void filler(string filler)
    {
        //this is only here to make sure OnEnemyKilledCombat stays active.
    }
}
