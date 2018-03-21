using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "HeroStats", menuName = "Hero/Hero Stats")]
public class PlayerStats : BaseCharacterStats {
    public WeaponType[] primaryWeapons;
    public int weaponSlotAmount;
    public int[] numWeaponUses;
}
