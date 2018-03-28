using UnityEngine;

public class InventoryUI : MonoBehaviour {
    public GameObject inventoryUI;
    public Transform weaponSlotsParent;
    PlayerInventory inventory;
    WeaponSlot[] slots;

	// Use this for initialization
	void Start () {
        inventory = PlayerInventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = weaponSlotsParent.GetComponentsInChildren<WeaponSlot>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
	}

    public void UpdateUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.weaponList.Count)
            {
                slots[i].AddWeapon(inventory.weaponList[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
