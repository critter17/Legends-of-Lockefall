using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class WeaponSlot : ItemSlot {

    public Weapon weapon;

    public void Select()
    {
        if(slotSelected && itemButton.enabled)
        {
            Debug.Log("fttthq");
            //EventSystem.current.firstSelectedGameObject = itemButton.gameObject;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(itemButton.gameObject);
        }
    }

    private void OnEnable()
    {
        //Select();
        //if(slotSelected && itemButton.enabled)
        //{
        //    Debug.Log("fttthq");
        //    EventSystem.current.firstSelectedGameObject = itemButton.gameObject;
        //}
    }

    private void OnDisable()
    {
        //if(EventSystem.current.currentSelectedGameObject != null)
        //{
        //    Debug.Log("Unselect");
        //    EventSystem.current.SetSelectedGameObject(null);
        //}
        ////EventSystem.current.firstSelectedGameObject = null;
        //slotSelected = false;
    }

    public void AddWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        icon.sprite = weapon.itemSprite;
        icon.enabled = true;
    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        weapon = null;
    }

    public void EquipWeapon()
    {
        weapon.InventoryItemAction();
    }
}
