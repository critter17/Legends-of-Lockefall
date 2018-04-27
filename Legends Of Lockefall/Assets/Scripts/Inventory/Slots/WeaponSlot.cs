using UnityEngine;
using UnityEngine.UI;

public class WeaponSlot : ItemSlot {

    public Weapon weapon;

    private void Start()
    {
        
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
