using UnityEngine;
using UnityEngine.UI;

public class WeaponSlot : ItemSlot {

    Weapon weapon;

    private void Start()
    {
        maxItems = 1;
    }

    public void AddWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        icon.sprite = weapon.itemSprite;
        icon.enabled = true;
    }

    public override void ClearSlot()
    {
        weapon = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void EquipWeapon()
    {
        weapon.InventoryItemAction();
    }
}
