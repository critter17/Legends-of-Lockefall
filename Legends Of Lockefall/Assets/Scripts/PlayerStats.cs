using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : BaseCharacterStats {
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

        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(1);
            onHeartsChangedCallback();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            TakeDamage(-1);
            onHeartsChangedCallback();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            maxHealth++;
        }

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
