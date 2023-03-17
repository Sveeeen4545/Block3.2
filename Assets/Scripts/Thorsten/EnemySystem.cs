using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{

    bool lookat = false;
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
    }
}

