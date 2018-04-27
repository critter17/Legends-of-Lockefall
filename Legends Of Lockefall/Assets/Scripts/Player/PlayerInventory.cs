using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour {
    #region Singleton
    public static PlayerInventory instance;

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

    public GameObject inventoryPanel;
    public WeaponInventory weaponInventory;
    public ArmorInventory armorInventory;
    public DisposableInventory disposableInventory;
    public ArtifactInventory artifactInventory;
    public EdibleInventory edibleInventory;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            gameObject.SetActive(false);
        }

    }

    private void Update()
    {
        if(Input.GetButtonDown("Inventory"))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}
