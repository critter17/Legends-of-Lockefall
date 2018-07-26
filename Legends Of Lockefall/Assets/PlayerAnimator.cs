using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : CharacterAnimator {
    public WeaponAnimations[] weaponAnimations;
    Dictionary<Weapon, AnimationClip[]> weaponAnimationsDict;

    protected override void Start()
    {
        base.Start();

        weaponAnimationsDict = new Dictionary<Weapon, AnimationClip[]>();
        foreach(WeaponAnimations a in weaponAnimations)
        {
            weaponAnimationsDict.Add(a.weapon, a.clips);
        }
    }

    void OnEquipmentChanged(Weapon newItem, Weapon oldItem)
    {
        
    }

    [System.Serializable]
    public struct WeaponAnimations
    {
        public Weapon weapon;
        public AnimationClip[] clips;
    }
}
