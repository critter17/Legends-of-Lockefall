using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementType { Normal, Fire, Ice, Water, Wind, Shock, Earth, Toxic, Magic, Blast, Monster, Ghoul, Deity, Chi, Morph };

public class BaseCharacterStats : MonoBehaviour {

    public int maxHealth = 3, currentHealth;
    public int baseAttack;
    public int baseDefense;
    ElementType characterElementType;
    
	void Start ()
    {
        
	}
	
	void Update ()
    {

    }
}
