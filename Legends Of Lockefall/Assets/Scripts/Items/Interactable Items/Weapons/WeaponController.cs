using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject currentWeapon;
    public Item[] currentEquippedItems;
    public Collider2D hitbox;
    public Animator weaponAnimator;

    // Use this for initialization
    void Start()
    {
        if(currentWeapon != null)
        {
            hitbox = currentWeapon.GetComponentInChildren<Collider2D>();
            hitbox.enabled = false;

            weaponAnimator = currentWeapon.GetComponent<Animator>();
        }
        currentEquippedItems = new Item[4];
    }

    public void Equip(Item newItem)
    {
        currentEquippedItems[0] = newItem;
    }

    public void UseWeapon()
    {
        StartCoroutine(WeaponAttack());
    }

    IEnumerator WeaponAttack()
    {
        yield return new WaitForSeconds(1);
    }
}
