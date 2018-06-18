using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public float movementForce = 30f;
    public float jumpForce = 20f;

	// Update is called once per frame
	void Update () {

        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(movementForce * Time.deltaTime, 0), ForceMode2D.Force);
        }
        if (Input.GetKey("a")) 
        {
            rb.AddForce(new Vector2(-movementForce * Time.deltaTime, 0), ForceMode2D.Force);
        }
        if (Input.GetKey("w"))
        {
            rb.velocity += (jumpForce * Vector2.up) * Time.deltaTime;
            //transform.position += transform.up * (jumpForce * Time.deltaTime);
        }
		
	}
}
