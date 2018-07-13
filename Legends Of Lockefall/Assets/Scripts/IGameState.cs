using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGameState {
    public Dictionary<string, InputAction> inputActions = new Dictionary<string, InputAction>();

    public virtual void DoAction(string buttonName)
    {
        if(inputActions.ContainsKey(buttonName))
        {
            inputActions[buttonName].PerformAction();
        }
    }
}
