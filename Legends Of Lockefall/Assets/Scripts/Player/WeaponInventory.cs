using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WeaponInventory : MonoBehaviour {
    public List<Weapon> weapons;
    public Image[] weaponSprites;

    private void Start()
    {
        weapons = new List<Weapon>();
        for(int i = 0; i < weapons.Count; i++)
        {
            weaponSprites[i].sprite = weapons[i].itemSprite;
        }
    }

    public void AddWeapon(Weapon newWeapon)
    {
        weapons.Add(newWeapon);
    }
}
