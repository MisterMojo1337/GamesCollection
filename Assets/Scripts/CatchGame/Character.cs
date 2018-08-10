using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float movementForce = 5f;
    public float angularSpeed = 7.5f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            transform.Rotate(Time.deltaTime, 10, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            transform.Rotate(Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, movementForce * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -movementForce * Time.deltaTime));
        }
    }
}
