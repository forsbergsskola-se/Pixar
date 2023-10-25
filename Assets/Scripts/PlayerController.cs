using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 10f;
    public float jumpForce = 5f;
    public float vInput; // to store the vertical axis

    public void Start()
    {
      
    }

    public void Update()
    {
        playerMovement();
        playerJump();
    }
    
    public void playerMovement()
    {
        
        vInput = Input.GetAxis("Horizontal") * movementSpeed;
        Vector3 moveVertical= new Vector3(vInput,0,0f);
        this.transform.Translate(moveVertical  * movementSpeed * Time.deltaTime, Space.World);

    }
 

    public void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsTouchingGround() == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, jumpForce));
            //rb.velocity = Vector3.up * jumpForce;
        } 
    }
    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");//if player touching the ground
        return Physics2D.IsTouchingLayers(GetComponent<BoxCollider2D>(), layerMask);
    }

}
