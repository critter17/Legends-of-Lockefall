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
    public GameObject player;

    private void Start()
    {
        Debug.Log("QSM");

        player = GameManager.instance.playerManager.player;

        items = player.GetComponentInChildren<WeaponController>().currentEquippedItems;
    }

    private void Update()
    {
        items = player.GetComponentInChildren<WeaponController>().currentEquippedItems;

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
