using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth {
    event System.Action<int, int, int> OnHPChanged;
    event System.Action OnDied;
    void TakeDamage(int amount);
    void Heal(int amount);
}
