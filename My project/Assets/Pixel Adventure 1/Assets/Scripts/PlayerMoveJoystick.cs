using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
     private float horizontalMove = 0f;
     private float verticalMove = 0f;
     public Joystick joystick;
    public float runSpeed = 1.25f;
    public float runSpeedHorizontal = 2;
    public float jumpSpeed = 3;

    Rigidbody2D rb2D;
    public SpriteRenderer spriteRendere;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void update(){

        //avanzar o retroceder teclas
       if(horizontalMove > 0)
       {
        spriteRendere.flipX = false;
       } 
       else if (horizontalMove < 0)
       {
        spriteRendere.flipX = true;
       }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //avanzar o retroceder con controles
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;      
    }

    public void Jump()
    {
        if (CheckGround.isGrounded)
       {
        rb2D.velocity = new Vector2(rb2D.velocity.x,jumpSpeed);
       }
    }
}
