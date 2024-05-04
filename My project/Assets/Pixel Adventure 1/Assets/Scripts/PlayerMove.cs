using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMove : MonoBehaviour
{
    
    public float runSpeed = 2;
    public float jumpSpeed = 3;

    Rigidbody2D rb2D;

    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;
    public SpriteRenderer spriteRendere;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //avanzar o retroceder
       if(UnityEngine.Input.GetKey("d") || UnityEngine.Input.GetKey("right"))
       {
        rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
        spriteRendere.flipX = false;
       } 
       else if (UnityEngine.Input.GetKey("a") || UnityEngine.Input.GetKey("left"))
       {
        rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        spriteRendere.flipX = true;
       }
       else
       {
        rb2D.velocity = new Vector2(0,rb2D.velocity.y);
       }

       //saltar
       if (UnityEngine.Input.GetKey("space") && CheckGround.isGrounded)
       {
        rb2D.velocity = new Vector2(rb2D.velocity.x,jumpSpeed);
       }

       if (betterJump)
       {
        if (rb2D.velocity.y<0)
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
        }
        if(rb2D.velocity.y>0 && !UnityEngine.Input.GetKey("space"))
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
        }
       }
    }
}
