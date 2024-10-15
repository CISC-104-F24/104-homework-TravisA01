using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    Vector3 movementForward = new Vector3 (0f, 0f, 1.0f); 
    Vector3 movementBackward = new Vector3 (0f, 0f, -1f);
    Vector3 movementRight = new Vector3 (1f, 0f, 0f);
    Vector3 movementLeft = new Vector3 (-1f, 0f, 0f);
    public float jumpPower = 10.0f;
    public float moveSpeed = 1.0f; 
    public float sprintSpeed = 3.0f;
    public float scaleSpeed = 5.0f; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Standard Forward
        bool forwardPressed = Input.GetKey(KeyCode.W);
        if (forwardPressed)
        {
            transform.position += new Vector3 (0f, 0f, 1f) * moveSpeed * Time.deltaTime;
        }

        //Standard Backward
        bool backwardPressed = Input.GetKey(KeyCode.S);
        if (backwardPressed)
        { 
            transform.position += new Vector3 (0f, 0f, -1f) * moveSpeed * Time.deltaTime;
        }

        //Standard Left
        bool leftPressed = Input.GetKey(KeyCode.A);
        if (leftPressed)
        {
            transform.position += new Vector3 (-1f, 0f, 0f) * moveSpeed * Time.deltaTime;
        }

        //Standard Right
        bool rightPressed = Input.GetKey(KeyCode.D);
        if (rightPressed)
        {
            transform.position += new Vector3 (1f, 0f, 0f) * moveSpeed * Time.deltaTime;
        }
        
        //Jump Controls
          bool is_jump_pressed = Input.GetKeyDown(KeyCode.Space);
          if (is_jump_pressed)
          {
            Rigidbody myRb = GetComponent<Rigidbody>();
            myRb.AddForce(new Vector3(0,1,0) * jumpPower, ForceMode.Impulse);
          } 
            
        //Sprint Forward
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed += sprintSpeed;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= sprintSpeed;
        }
        
        //Scale
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localScale = new Vector3(0.02f, 0.02f, 0.02f) * scaleSpeed;
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            transform.localScale = new Vector3(0.48f, 0.48f, 0.48f) * scaleSpeed;
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            transform.localScale = new Vector3(0.18f, 0.18f, 0.18f) * scaleSpeed;
        }
    }
 }
        
            
    
