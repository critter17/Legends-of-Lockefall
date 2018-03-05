using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizardman : PatrolEnemyController {

    public float attackRadius = 2;
    public bool attacking = false, canAttack = true;
    public float attackDelay;
    public float cooldownDelay;

    public override void ChaseAndAttack()
    {
        base.ChaseAndAttack();
        float distance = Vector2.Distance(transform.position, PlayerManager.instance.player.transform.position);
        if (distance <= attackRadius)
        {
            if(!attacking && canAttack)
                StartCoroutine(Attack());
        }
        else
        {
            if (!attacking)
            {
                transform.position = Vector2.MoveTowards(transform.position, PlayerManager.instance.player.transform.position, moveSpeed * Time.deltaTime);
                DetectDirection(PlayerManager.instance.player.transform);
            }
        }

        anim.SetBool("Attacking", attacking);
    }

    IEnumerator Attack()
    {
        canAttack = false;
        attacking = true;
        yield return new WaitForSeconds(attackDelay);
        attacking = false;
        yield return new WaitForSeconds(cooldownDelay);
        canAttack = true;
    }
}
