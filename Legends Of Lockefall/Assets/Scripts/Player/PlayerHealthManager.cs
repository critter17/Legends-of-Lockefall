using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {
    HeroStatManager hero;

    public Transform heartParent;
    Image[] hearts;
    public GameObject heartPrefab;
    public Sprite fullHeart, emptyHeart;
    InitializeHearts initHearts;

    public delegate void OnHeartsChanged();
    public OnHeartsChanged onHeartsChangedCallback;

    // Use this for initialization
    void Start () {
        hero = GetComponent<HeroStatManager>();
        hero.heroStats.currentHealth = hero.heroStats.maxHealth;
        onHeartsChangedCallback += UpdateHearts;
        UpdateHearts();
    }
	
	// Update is called once per frame
	void Update () {
        hero.heroStats.currentHealth = Mathf.Clamp(hero.heroStats.currentHealth, 0, hero.heroStats.maxHealth);
        hero.heroStats.maxHealth = Mathf.Clamp(hero.heroStats.maxHealth, 3, 19);

        if(hearts.Length < hero.heroStats.maxHealth)
        {
            GameObject newHeart;
            newHeart = Instantiate(heartPrefab);
            newHeart.transform.SetParent(heartParent);

            onHeartsChangedCallback();
        }
    }

    public void TakeDamage(int damage)
    {
        hero.heroStats.currentHealth -= damage;
        onHeartsChangedCallback();
    }

    public void Heal(int amountToHeal)
    {
        hero.heroStats.currentHealth += amountToHeal;
        onHeartsChangedCallback();
    }

    void UpdateHearts()
    {
        hearts = heartParent.GetComponentsInChildren<Image>();

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < hero.heroStats.currentHealth)
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
