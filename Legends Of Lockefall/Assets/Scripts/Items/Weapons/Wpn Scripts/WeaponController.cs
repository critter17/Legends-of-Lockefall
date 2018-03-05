using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    [HideInInspector] public Collider2D hitbox;

	// Use this for initialization
	void Start () {
        hitbox = GetComponentInChildren<Collider2D>();
        hitbox.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
