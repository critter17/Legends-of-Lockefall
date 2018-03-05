using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    private PlayerHealthManager playerHealth;

	// Use this for initialization
	void Start () {
        playerHealth = FindObjectOfType<PlayerHealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("hello");
            playerHealth.TakeDamage(GetComponentInParent<EnemyHealthManager>().enemyStats.baseStrength);
        }
    }
}
