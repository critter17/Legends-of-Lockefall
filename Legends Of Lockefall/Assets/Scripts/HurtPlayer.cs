using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    private PlayerStats playerStats;

	// Use this for initialization
	void Start () {
        playerStats = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerStats.TakeDamage(GetComponentInParent<EnemyStats>().baseAttack);
        }
    }
}
