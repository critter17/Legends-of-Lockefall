using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType { Longsword, Shortsword, Dagger, Axe, Bow, Staff, Whip, Blaster, Mace, Hammer, BrassKnuckles };

[CreateAssetMenu(menuName = "Items/Weapon")]
public class Weapon : Item {
    public WeaponType weaponType;
    public int attackPower;
    public int elementPower;
    public Element element;
    private bool canBreak = false;
    private int numOfUses = -1;

    public void SetBreakable(bool canBreak)
    {
        this.canBreak = canBreak;
    }

    public override void ItemAction(GameObject player)
    {
        Debug.Log("Weapon action");
    }

    public void DisplayWeaponStats()
    {

    }
}
