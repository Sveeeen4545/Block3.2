using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{

    /* bool lookat = false;
     public GameObject player;
     public Rigidbody rb;
     public float speed = 10;
     public float multiplier = 10;
     public float speed_limit = 2;

     private void start()
     {
         rb = GetComponent<Rigidbody>();
     }

     // Update is called once per frame
     void Update()
     {
         if (PlayerDetection.found)
         {
             lookat = true;
         }
         if (lookat)
         {
             transform.LookAt(player.transform);
            // Vector3 vel = velocity;
             if (!PlayerDetection.found)
             {
                 rb.AddForce(speed * transform.forward);
             }
         }
     }*/

    public Transform Player;
    public int MoveSpeed = 100;
    public int MaxDist = 10;
    public int MinDist = 1;
    public Rigidbody rb;

    Vector3 velocity;
    bool isGrounded;
    public Transform groundCheck;
    public float groundDIstance = 0.4f;
    public LayerMask groundMask;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var v3 = transform.forward;
        v3.y = 0.0f;

        //if (isGrounded && velocity.y < 0)
        //{
        //     velocity.y = -2f;
        //}

        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDIstance, groundMask);

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or somet$$anonymous$$ng
            }

        }
    }
}

