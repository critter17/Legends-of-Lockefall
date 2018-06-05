using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {
    PlayerStats hero;
    Animator anim;
    PlayerController playerController;
    WeaponController weaponController;
    private int baseDamage;
    public float attackSpeed;
    
	void Start ()
    {
        hero = GameManager.instance.playerManager.playerStats;
        anim = GetComponent<Animator>();
        playerController = GameManager.instance.playerManager.playerMovement;
        weaponController = GetComponentInChildren<WeaponController>();
        baseDamage = hero.baseStrength;
	}
	
	void Update ()
    {
		if(playerController.canMove == true)
        {
            if(Input.GetButtonDown("Fire1") && weaponController.currentWeapon != null)
            {
                StartCoroutine(Attack());
                weaponController.UseWeapon();
            }
        }
	}

    IEnumerator Attack()
    {
        anim.SetBool("Attack", true);
        playerController.CanMove(false);
        weaponController.hitbox.enabled = true;
        Debug.Log("Movement off: " + playerController.playerRigidBody.velocity);
        yield return new WaitForSeconds(attackSpeed);
        anim.SetBool("Attack", false);
        playerController.CanMove(true);
        weaponController.hitbox.enabled = false;
        Debug.Log("Movement on: " + playerController.playerRigidBody.velocity);
    }
}
