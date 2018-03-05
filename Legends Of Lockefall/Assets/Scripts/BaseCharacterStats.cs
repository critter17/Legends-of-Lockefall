using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterStats : ScriptableObject {
    public new string name;
    public Sprite sprite;
    public int maxHealth, currentHealth;
    public int baseStrength;
    public int baseDefense;
    public int baseSpeed;
    public ElementType[] characterElementType;

    public int normalResistance;
    public int fireResistance;
    public int iceResistance;
    public int waterResistance;
    public int windResistance;
    public int shockResistance;
    public int earthResistance;
    public int toxicResistance;
    public int magicResistance;
    public int blastResistance;
    public int monsterResistance;
    public int ghoulResistance;
    public int chiResistance;
}
