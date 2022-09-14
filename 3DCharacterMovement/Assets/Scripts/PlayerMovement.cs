using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController controller;
    

    public float speed;
    public float gravity;
    public float rotSpeed;

    private float rot;
    private Vector3 moveDirection;
    


    void Start()
    {
        controller = GetComponent<CharacterController>();

        
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {

        if (controller.isGrounded)
        {

            if (Input.GetKey(KeyCode.W))
            {

                moveDirection = Vector3.forward * speed;


            }

            if (Input.GetKeyUp(KeyCode.W))
            {

                moveDirection = Vector3.zero;

            }

            
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);
        
        controller.Move(moveDirection * Time.deltaTime);

    }
}
