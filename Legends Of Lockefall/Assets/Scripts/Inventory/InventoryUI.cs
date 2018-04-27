using UnityEngine;

public class InventoryUI : MonoBehaviour {
 //   public GameObject inventoryUI;
 //   public Transform weaponSlotsParent;
 //   public Transform edibleSlotsParent;
 //   PlayerInventory inventory;

 //   WeaponSlot[] weaponSlots;
 //   EdibleSlot[] edibleSlots;

	//// Use this for initialization
	//void Start () {
 //       inventory = PlayerInventory.instance;
 //       inventory.onItemChangedCallback += UpdateUI;

 //       weaponSlots = weaponSlotsParent.GetComponentsInChildren<WeaponSlot>();
 //       edibleSlots = edibleSlotsParent.GetComponentsInChildren<EdibleSlot>();
	//}
	
	//// Update is called once per frame
	//void Update () {
	//	if(Input.GetButtonDown("Inventory"))
 //       {
 //           inventoryUI.SetActive(!inventoryUI.activeSelf);
 //       }
	//}

 //   public void UpdateUI()
 //   {
 //       UpdateWeaponSlots();
 //       UpdateEdibleSlots();
 //   }

 //   private void UpdateWeaponSlots()
 //   {
 //       for(int i = 0; i < weaponSlots.Length; i++)
 //       {
 //           if(i < inventory.weapons.Count)
 //           {
 //               weaponSlots[i].AddWeapon(inventory.weapons[i]);
 //           }
 //           else
 //           {
 //               weaponSlots[i].ClearSlot();
 //           }
 //       }
 //   }

 //   private void UpdateEdibleSlots()
 //   {
 //       for(int i = 0; i < edibleSlots.Length; i++)
 //       {
 //           if(i < inventory.edibleList.Count)
 //           {
 //               edibleSlots[i].AddEdible(inventory.edibleList[i]);
 //           }
 //           else
 //           {
 //               edibleSlots[i].ClearSlot();
 //           }
 //       }
 //   }
}
