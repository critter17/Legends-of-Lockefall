using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickSlotManager : MonoBehaviour {
    #region Singleton
    public static QuickSlotManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    #endregion

    public Item[] items;
    public Image[] quickSlotImages;
    public WeaponController weaponController;

    private void Start()
    {
        weaponController = GameManager.instance.playerManager.weaponController;
        items = weaponController.currentEquippedItems;
    }

    private void OnEnable()
    {
        weaponController = GameManager.instance.playerManager.weaponController;
        //items = weaponController.currentEquippedItems;
    }

    private void OnDisable()
    {
        weaponController = null;
        items = null;
    }

    private void Update()
    {
        items = weaponController.currentEquippedItems;

        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] != null)
            {
                quickSlotImages[i].sprite = items[i].itemSprite;
                quickSlotImages[i].enabled = true;
            }
            else
            {
                quickSlotImages[i].sprite = null;
                quickSlotImages[i].enabled = false;
            }
        }
    }
}
