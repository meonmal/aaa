using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 MoveDir = Vector2.zero;
    public float MoveSpeed = 5.0f;


    public void Update()
    {
        UpdateInput();
    }


    public void UpdateInput()
    {
        Vector3 MoveDir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            MoveDir.y += 1;
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            MoveDir.x -= 1;
        }
            
        if (Input.GetKey(KeyCode.S))
        {
            MoveDir.y -= 1;
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            MoveDir.x += 1;
        }

        //MoveDir = Manager.Game.MoveDir;


        MoveDir = MoveDir.normalized;

        Vector3 dir = MoveDir * MoveSpeed * Time.deltaTime;
        transform.position += dir;
    }
}
