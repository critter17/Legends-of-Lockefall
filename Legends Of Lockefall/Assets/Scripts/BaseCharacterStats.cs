using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseCharacterStats : ScriptableObject {
    public new string name;
    public int maxHealth, currentHealth;
    public int baseStrength;
    public int baseDefense;
    public int baseSpeed;
    public ElementType[] characterElementTypes;
}
