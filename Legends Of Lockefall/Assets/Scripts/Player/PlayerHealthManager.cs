using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public IHealth health;
    public HeartMeter heartsParent;

    // Use this for initialization
    void Start () {
        heartsParent = FindObjectOfType<HeartMeter>();
        health = new HeartHealth(heartsParent, gameObject);
        heartsParent.Subscribe();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(1);
        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            Heal(1);
        }
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }

    public void Heal(int amountToHeal)
    {
        health.Heal(amountToHeal);
    }

    private void OnDestroy()
    {
        heartsParent.Unsubscribe();
    }
}
