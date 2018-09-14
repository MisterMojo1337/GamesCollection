using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Mario>().jumpCounter++;
    }
}
