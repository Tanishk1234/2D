// created by a tanishk agrawal which lives in mathura to develop its game so ask them first to use this code
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// dream prozects
public class CharacterController2D : MonoBehaviour

{
  
 [SerializeField] private LayerMask dashLayerMask;

  private float moveSpeed = 5f;
  private Rigidbody2D rigidBody2d;
  public Animator animator;
  private Vector3 moveDir;
  private bool isDashButtonDown;

  public GameObject dashEffect;

    private void Awake()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");
      
        animator.SetFloat("Horizontal", moveDir.x);
        animator.SetFloat("Vertical", moveDir.y);
        animator.SetFloat("Speed", moveDir.sqrMagnitude);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Instantiate(dashEffect, transform.position , Quaternion.identity);
            isDashButtonDown = true;
        }
    }

    private void FixedUpdate()
    {
         rigidBody2d.velocity = moveDir * moveSpeed;

         if(isDashButtonDown)
         {
             float dashAmount = 5f;
             Vector3 dashPosition = transform.position + moveDir * dashAmount;
          RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, moveDir , dashAmount , dashLayerMask);
            
            if (raycastHit2D.collider != null)
            {
                dashPosition = raycastHit2D.point;
            }
            rigidBody2d.MovePosition(dashPosition);
            isDashButtonDown = false;
         }
    }

   
}
