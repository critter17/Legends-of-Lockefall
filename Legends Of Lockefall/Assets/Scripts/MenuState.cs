using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : IGameState
{
    InputAction move = new MoveAction();

    public MenuState()
    {
        inputActions.Add("A_Button", move);
    }
}
