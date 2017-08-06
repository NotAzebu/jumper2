using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    
    // Use this for initialization
    //void Start ()

    public float jumpForce = 6.0f;
    private Rigidbody2D rigidBody;
    public float jumpRaycast = 0.6f;
    public float runningSpeed = 1.0f;
    private bool jumpPressed = false;

    //public bool isGrounded;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame

    void FixedUpdate()
    {
        if (rigidBody.velocity.x < runningSpeed)
        {
            rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
        }
        if (jumpPressed)
        {
            Jump();
        }
      
    }
    

    void Update()
    {
        if (Input.GetKey("space"))
        {
        Debug.Log("Jump Button Pressed");
        jumpPressed = true;
        }
        else
        {
            jumpPressed = false;
        }
       // if (Input.GetKey("space"))
       // {
       //     Debug.Log("Jump button pressed");
       //     Jump();
       // }
    }
    void Jump()
    {
        if (IsGrounded())
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public LayerMask groundLayer;

    bool IsGrounded()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, jumpRaycast, groundLayer.value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}