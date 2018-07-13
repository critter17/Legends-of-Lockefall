using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : InputAction
{
    public MoveAction()
    {

    }

    public override void PerformAction()
    {
        GameManager.instance.playerManager.playerMovement.canMove = false;
    }
}
