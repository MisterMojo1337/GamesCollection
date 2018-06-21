﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Player : MonoBehaviour {
    
    public GameObject graveStone;
    public Rigidbody2D rb;

    public float movementForce = 5f;
    public float jumpForce = 300f;
    private float distToGround;
    public float playerTime;

    private void Start()
    {
        distToGround = transform.position.y;
    }
    // Update is called once per frame
    void Update () {

        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
        }
        if (Input.GetKey("a")) 
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
        }
        if (Input.GetKey("w"))
        {
            if (distToGround + 0.1 >= transform.position.y)
            {
                rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            }
           
        }

        if (FindObjectsOfType<Rock>().Any(x => x.gotPlayerHit))
        {
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        Destroy(gameObject);
        Instantiate(graveStone, transform.position, transform.rotation);
    }
}
