using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{

    public Joystick joystick;
    public CharacterController2D controller;
    public GameObject Player;
    public Rigidbody2D rB;
    public Animator animator;
    public AudioClip Jump_;
    public AudioSource AudioSource;
    float horizontalMove = 0f;
    public float rSpeed = 40f;
    
    bool jump = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Collition.done == false)
        {
            rB.constraints = RigidbodyConstraints2D.None;
            rB.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (Input.GetAxisRaw("Horizontal") * rSpeed == 0)
            {
                horizontalMove = joystick.Horizontal * rSpeed;
            }
            else if (joystick.Horizontal * rSpeed == 0)
            {
                horizontalMove = Input.GetAxisRaw("Horizontal") * rSpeed;
            }
            //horizontalMove = Input.GetAxisRaw("Horizontal") * rSpeed;
            //horizontalMove = joystick.Horizontal * rSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


            if (Input.GetButtonDown("Jump") || Pressed.Press == true)
            //if(Pressed.Press == true)
            {
                jump = true;
                animator.SetBool("Jump", true);
                AudioSource.clip = Jump_;
                AudioSource.Play();
            }
        }
        else if (Collition.done == true)
        {
            rB.constraints = RigidbodyConstraints2D.FreezePosition;
            
            
        }
        
        
    }

    public void onLanding()
    {
        animator.SetBool("Jump", false);
        
    }

    void FixedUpdate()
    {
        if (Collition.done == false)
        {


            //movment
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
            Pressed.Press = false;
        }

    }
}
