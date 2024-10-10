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
        MovePlayer();
    }


    public void UpdateInput()
    {
        Vector2 MoveDir = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            MoveDir.y += 1;
        if (Input.GetKey(KeyCode.A))
            MoveDir.x -= 1;
        if (Input.GetKey(KeyCode.S))
            MoveDir.y -= 1;
        if (Input.GetKey(KeyCode.D))
            MoveDir.x += 1;

        MoveDir = MoveDir.normalized;
    }

    public void MovePlayer()
    {
        Vector3 dir = MoveDir * MoveSpeed * Time.deltaTime;
        transform.position += dir;
    }
}
