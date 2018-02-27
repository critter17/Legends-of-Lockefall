using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType { Longsword, Shortsword, Dagger, Axe, Mace, Hammer, Bow, Blaster, BoStaff, Whip, BrassKnuckles };

public class BaseWeapon : MonoBehaviour {
    public string weaponName;
    public int baseAttack;
    public int elementAttack;
    WeaponType weaponType;
    public ElementType elementType;
    public bool canBreak;
    public int numOfUses;

	// Use this for initialization
	void Start () {
        canBreak = false;
        numOfUses = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if(canBreak && numOfUses <= 0)
        {
            // Destroy weapon, play weapon destroyed animation
            Destroy(this.gameObject);
        }
	}

    public void SetWeaponType(WeaponType weaponType)
    {
        this.weaponType = weaponType;
    }

    public void SetElementType(ElementType elementType)
    {
        this.elementType = elementType;
    }

    public void SetNumOfUses()
    {

    }
    

    void Equip()
    {

    }

    public virtual void SpecialAttack()
    {

    }

    void ReduceUsages()
    {
        numOfUses--;
    }
}
