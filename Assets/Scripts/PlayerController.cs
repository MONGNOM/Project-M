using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField,Range(0,50)]
    private float moveSpeed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        rigid.velocity = new Vector3(input.x * moveSpeed, 0 ,input.y * moveSpeed);
        Debug.LogFormat("{0}","방향키누르는중");
    }
}
