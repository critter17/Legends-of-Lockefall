using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : BaseCharacterStats {

    public int[] numWeaponUses;
    public Transform heartParent;
    Image[] hearts;
    public GameObject heartPrefab;
    public Sprite fullHeart, emptyHeart;

    public delegate void OnHeartsChanged();
    public OnHeartsChanged onHeartsChangedCallback;
    
	void Start ()
    {
        currentHealth = maxHealth;
        onHeartsChangedCallback += UpdateHearts;
        UpdateHearts();
	}
	
	void Update ()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        maxHealth = Mathf.Clamp(maxHealth, 3, 19);

        if (hearts.Length < maxHealth)
        {
            GameObject newHeart;
            newHeart = Instantiate(heartPrefab);
            newHeart.transform.SetParent(heartParent);

            onHeartsChangedCallback();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        onHeartsChangedCallback();
    }

    void UpdateHearts()
    {
        hearts = heartParent.GetComponentsInChildren<Image>();

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
