using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : IGameState
{
    public GameState()
    {
        inputActions.Add("A_Button", new InteractAction());
    }
}
