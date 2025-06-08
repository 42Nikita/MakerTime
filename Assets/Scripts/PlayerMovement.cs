using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 15f;
    private float gravity = 5f;
    private Rigidbody rb;
    private bool isGrounded = true;
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    private float currentSpeed;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
            isGrounded = true;
        }
        float Speed = walkSpeed;
        
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = sprintSpeed;
        }
       
       
        
    }
}
