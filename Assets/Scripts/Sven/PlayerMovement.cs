using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    //Animation of noteblock

    public float speed = 12f;
    public float sprintingSpeed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDIstance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    //Animation of noteblock
    public Animator m_Animator;
    public bool NotepadToFront = true;

    // Update is called once per frame
    void Update()
    {
        //check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDIstance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Axis for the input system
        float x = Input.GetAxis("HorizontalMove");
        float z = Input.GetAxis("VerticalMove");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //Jumping method
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Sprinting
        if (Input.GetButton("Sprint") || Input.GetButton("SprintController"))
        {
            controller.Move(move * speed * 1.5f * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("Notepad") && NotepadToFront)
        {
            m_Animator.SetBool("GoToFront", true);
            m_Animator.SetBool("GoToSide", false);
            NotepadToFront = false;
        }


        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetButtonDown("Notepad") && !NotepadToFront)
        {
            m_Animator.SetBool("GoToFront", false);
            m_Animator.SetBool("GoToSide", true);
            NotepadToFront = true;
        }



    }



    //m_Animator.SetBool("Jump", true);


}
