using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    PlayerStats hero;
    Animator anim;
    PlayerController playerController;
    WeaponController weaponController;
    private int baseDamage;
    public float attackSpeed;

    void Start()
    {
        hero = GameManager.instance.playerManager.playerStats;
        anim = GetComponent<Animator>();
        playerController = GameManager.instance.playerManager.playerMovement;
        weaponController = GetComponentInChildren<WeaponController>();
        baseDamage = hero.baseStrength;
    }

    void Update()
    {
        if(playerController.CanMove == true)
        {
            if(Input.GetButtonDown("Fire1") && weaponController.currentEquippedItems[0] != null)
            {
                Debug.Log("Heyeyeyey");
                Debug.Log("kj");
                StartCoroutine(Attack());
                weaponController.UseWeapon();
            }
        }
    }

    IEnumerator Attack()
    {
        anim.SetBool("Attack", true);
        playerController.CanMove = false;
        yield return new WaitForSeconds(attackSpeed);
        anim.SetBool("Attack", false);
        playerController.CanMove = true;
    }
}
