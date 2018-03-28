using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
    public GameObject currentWeapon;
    public List<Weapon> weaponQuickSlots;
    [HideInInspector] public Collider2D hitbox;
    [HideInInspector] public Animator weaponAnimator;

    // Use this for initialization
    void Start () {
        if(currentWeapon != null)
        {
            hitbox = currentWeapon.GetComponentInChildren<Collider2D>();
            hitbox.enabled = false;

            weaponAnimator = currentWeapon.GetComponent<Animator>();
        }
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
