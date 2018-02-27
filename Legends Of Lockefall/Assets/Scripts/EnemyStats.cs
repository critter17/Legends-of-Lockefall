using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : BaseCharacterStats {

    public string EnemyName;

    public float damageBoostTime;
    public bool damageBoosting = false;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
	}

    public void TakeDamage(int damage)
    {
        if (!damageBoosting)
        {
            currentHealth -= damage;
            StartCoroutine(DamageBoost());
        }
    }

    public void Die()
    {
        PlayerManager.instance.OnEnemyKilledCallback.Invoke(EnemyName);
        Destroy(this.gameObject);
    }

    IEnumerator DamageBoost()
    {
        damageBoosting = true;
        yield return new WaitForSeconds(damageBoostTime);
        damageBoosting = false;
    }
}
