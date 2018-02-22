﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {

    public int maxHealth;
    public int currentHealth;
    public Slider healthBar;

    public float damageBoostTime;
    public bool damageBoosting = false;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
	}

    public void TakeDamage(int damage)
    {
        if (!damageBoosting)
        {
            currentHealth -= damage;
            StartCoroutine(DamageBoost());
        }
    }

    IEnumerator DamageBoost()
    {
        damageBoosting = true;
        yield return new WaitForSeconds(damageBoostTime);
        damageBoosting = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Weapon")
        {
            TakeDamage(collision.GetComponentInParent<PlayerCombat>().baseDamage);
        }
    }
}
