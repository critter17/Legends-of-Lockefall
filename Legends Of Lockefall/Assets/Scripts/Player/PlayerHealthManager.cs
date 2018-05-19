using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {
    HeroStatManager hero;

    public HeartsUI heartsParent;

    // Use this for initialization
    void Start () {
        heartsParent = FindObjectOfType<HeartsUI>();
        hero = GetComponent<HeroStatManager>();
        hero.heroStats.currentHealth = hero.heroStats.maxHealth;
 
        for(int i = 0; i < hero.heroStats.maxHealth; i++)
        {
            Debug.Log("Trying to create hearts");
            heartsParent.CreateHeart();
        }

        heartsParent.UpdateHearts(hero.heroStats.currentHealth);
    }
	
	// Update is called once per frame
	void Update () {
        hero.heroStats.currentHealth = Mathf.Clamp(hero.heroStats.currentHealth, 0, hero.heroStats.maxHealth);
        hero.heroStats.maxHealth = Mathf.Clamp(hero.heroStats.maxHealth, 3, 20);
    }

    public void TakeDamage(int damage)
    {
        hero.heroStats.currentHealth -= damage;
        
    }

    public void Heal(int amountToHeal)
    {
        hero.heroStats.currentHealth += amountToHeal;
        
    }
}
