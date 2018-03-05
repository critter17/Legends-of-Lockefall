using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementType { Normal, Fire, Ice, Water, Wind, Shock, Earth, Toxic, Magic, Blast, Monster, Ghoul, Chi };

[CreateAssetMenu(fileName = "Element", menuName = "Element")]
public class Element : ScriptableObject {
    public ElementType element;
    [SerializeField] public IDictionary<ElementType, float> elementWeaknessMultipliers = new Dictionary<ElementType, float>();

    public void Initialize()
    {
        switch(element)
        {
            case ElementType.Normal:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Fire:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Ice:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Water:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Wind:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Shock:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Earth:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Toxic:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;
            case ElementType.Magic:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Blast:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Monster:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Ghoul:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;

            case ElementType.Chi:
                elementWeaknessMultipliers.Add(ElementType.Normal, 1f);
                elementWeaknessMultipliers.Add(ElementType.Fire, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ice, 1f);
                elementWeaknessMultipliers.Add(ElementType.Water, 1f);
                elementWeaknessMultipliers.Add(ElementType.Wind, 1f);
                elementWeaknessMultipliers.Add(ElementType.Shock, 1f);
                elementWeaknessMultipliers.Add(ElementType.Earth, 1f);
                elementWeaknessMultipliers.Add(ElementType.Toxic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Magic, 1f);
                elementWeaknessMultipliers.Add(ElementType.Blast, 1f);
                elementWeaknessMultipliers.Add(ElementType.Monster, 1f);
                elementWeaknessMultipliers.Add(ElementType.Ghoul, 1f);
                elementWeaknessMultipliers.Add(ElementType.Chi, 1f);
                break;
        }
    }
}
