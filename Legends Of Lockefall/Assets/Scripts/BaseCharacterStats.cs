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
    public ElementType[] characterElementTypes;
}
