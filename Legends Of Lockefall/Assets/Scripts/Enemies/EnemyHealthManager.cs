using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public EnemyStats enemyStats;
    public int currentHealth, maxHealth;
    public string EnemyName;
    public float damageBoostTime;
    public bool damageBoosting = false;

    void Start()
    {
        currentHealth = enemyStats.currentHealth;
        maxHealth = enemyStats.currentHealth;
        currentHealth = maxHealth;
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        if(!damageBoosting)
        {
            currentHealth -= damage;
            StartCoroutine(DamageBoost());
        }
    }

    public void Die()
    {
        GameManager.instance.playerManager.OnEnemyKilledCallback.Invoke(EnemyName);
        Destroy(gameObject);
    }

    IEnumerator DamageBoost()
    {
        damageBoosting = true;
        yield return new WaitForSeconds(damageBoostTime);
        damageBoosting = false;
    }
}
