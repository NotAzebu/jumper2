using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Use this for initialization
	//void Start ()

    public float jumpForce = 6.0f;
    private Rigidbody2D rigidBody;
	
	
    void awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
        {
        if (Input.GetMouseButtonDown(0))
            {
            Debug.Log("spacebar pressed");
            Jump();
            }
    }
        void Jump()
            {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
}
