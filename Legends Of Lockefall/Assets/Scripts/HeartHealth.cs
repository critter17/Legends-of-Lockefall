using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHealth : IHealth {
    private readonly int maxHealth;
    private int currentHealth;
    public GameObject owner;
    public HeartMeter heartsParent;

    public event Action<int, int, int> OnHPChanged = delegate { };
    public event Action OnDied = delegate { };
    
    public HeartHealth(HeartMeter _heartsParent, GameObject _owner)
    {
        heartsParent = _heartsParent;
        currentHealth = GameManager.instance.playerManager.playerStats.currentHealth;
        maxHealth = GameManager.instance.playerManager.playerStats.maxHealth;
        owner = _owner;

        heartsParent.CreateHearts(NumHearts);
        heartsParent.ResetHealth();
    }

    public int NumHearts
    {
        get { return maxHealth / 4; }
    }

    public int NumFullHearts
    {
        get { return currentHealth / 4; }
    }

    public int RemainderHearts
    {
        get { return currentHealth % 4; }
    }

    protected virtual void HPChanged()
    {
        OnHPChanged?.Invoke(NumHearts, NumFullHearts, RemainderHearts);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Current Health: " + currentHealth);

        HPChanged();

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        HPChanged();
    }

    private void Die()
    {
        OnDied?.Invoke();
        UnityEngine.Object.Destroy(owner);
    }
}
