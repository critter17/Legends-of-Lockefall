using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon")]
public class Weapon : Item {
    public int attackPower;
    public Element element;
    private bool canBreak = false;
    private int numOfUses = -1;

    public void SetBreakable(bool canBreak)
    {
        this.canBreak = canBreak;
    }
}
