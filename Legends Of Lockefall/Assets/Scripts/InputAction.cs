using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction {
    public string actionString;
    public abstract void PerformAction();
}
