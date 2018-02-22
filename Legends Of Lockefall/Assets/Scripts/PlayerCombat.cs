using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

    Animator anim;
    PlayerController playerController;
    public int baseDamage;
    public float attackSpeed;
    
	void Start ()
    {
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
	}
	
	void Update ()
    {
		if(playerController.canMove == true)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(Attack());
            }
        }
	}

    IEnumerator Attack()
    {
        anim.SetBool("Attack", true);
        playerController.CanMove(false);
        yield return new WaitForSeconds(attackSpeed);
        anim.SetBool("Attack", false);
        playerController.CanMove(true);
    }
}
