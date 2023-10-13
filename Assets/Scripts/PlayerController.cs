using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;
    private Animator anim;
    [SerializeField,Range(0,50)]
    private float moveSpeed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        rigid.velocity = new Vector3(input.x * moveSpeed, rigid.velocity.y ,input.y * moveSpeed);
        anim.SetFloat("XInput", rigid.velocity.x);
        anim.SetFloat("YInput", rigid.velocity.z);

        //transform.Translate(new Vector3(input.x * moveSpeed, rigid.velocity.y, input.y * moveSpeed) * Time.deltaTime);
    }

    private void OnLook(InputValue value)
    { 
        //transform.LookAt(transform.position + new Vector3(input.x, 0, input.y));
        
    }
}
    