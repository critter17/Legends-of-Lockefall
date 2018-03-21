using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour {
    public Weapon weapon;
    public SpriteRenderer spriteRenderer;
    [HideInInspector] public string itemName;
    [HideInInspector] public WeaponType weaponType;
    [HideInInspector] public Element element;
    [HideInInspector] public int attackPower;
    [HideInInspector] public int elementPower;

    private void Start()
    {
        itemName = weapon.itemName;
        spriteRenderer.sprite = weapon.itemSprite;
        weaponType = weapon.weaponType;
        element = weapon.element;
        attackPower = weapon.attackPower;
        elementPower = weapon.elementPower;
    }
}
