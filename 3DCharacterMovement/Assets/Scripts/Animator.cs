using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    private Animator anim;
    

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            anim.SetBool("IsMoving", true);


        }

        else
        {

            anim.SetBool("IsMoving", false);


        }

        
        
        if (Input.GetKey(KeyCode.LeftShift))
        {


            anim.SetBool("IsRunning", true);


        }

        else
        {

            anim.SetBool("IsRunning", false);


        }


        if (Input.GetKey(KeyCode.S))
        {

            anim.SetBool("IsWalkingB", true);


        }

        else 
        {

            anim.SetBool("IsWalkingB", false);

        }

        if (Input.GetKey(KeyCode.D))
        {

            anim.SetBool("IsWalkingR", true);

        }

        else
        {

            anim.SetBool("IsWalkingR", false);

        }

        if (Input.GetKey(KeyCode.A))
        {

            anim.SetBool("IsWalkingL", true);



        }

        else
        {

            anim.SetBool("IsWalkingL", false);

        }
    
    }
}
