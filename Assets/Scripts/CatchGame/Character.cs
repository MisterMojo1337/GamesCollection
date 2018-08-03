using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float movementForce = 5f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            transform.Rotate(Vector3.back* Time.deltaTime, 7.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            transform.Rotate(Vector3.forward * Time.deltaTime, 7.5f);
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
