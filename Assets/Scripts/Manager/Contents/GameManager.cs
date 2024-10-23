using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    Vector2 moveDir;
    public Vector2 MoveDir
    {
        get
        {
            return moveDir;
        }
        set
        {
            moveDir = value;
        }
    }
}
