using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[Serializable]
public class PlayerManager {
    public GameObject player;
    public PlayerInventory playerInventory;

    [HideInInspector] public PlayerController playerMovement;
    [HideInInspector] public PlayerCombat playerCombat;

    public delegate void OnEnemyKilled(string EnemyName); // I'm just putting it here because I can.
    public OnEnemyKilled OnEnemyKilledCallback;

    void Filler(string filler)
    {
        //this is only here to make sure OnEnemyKilledCombat stays active.
    }

    public void Setup()
    {
        OnEnemyKilledCallback += Filler;
        playerMovement = player.GetComponent<PlayerController>();
        playerCombat = player.GetComponent<PlayerCombat>();
    }
}
