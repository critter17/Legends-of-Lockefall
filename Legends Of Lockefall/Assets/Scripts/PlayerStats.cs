using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : BaseCharacterStats {
    public Slider healthBar;

	void Start ()
    {
        currentHealth = maxHealth;
	}
	
	void Update ()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(5);
        }
	}

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
