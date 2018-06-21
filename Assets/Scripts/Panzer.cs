using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Panzer : MonoBehaviour
{

    public GameObject graveStone;
    public Rigidbody2D rb;

    public float movementForce = 30f;
    public float jumpForce = 20f;
    private float distToGround;


    private void Start()
    {
        distToGround = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (distToGround + 0.1 >= transform.position.y)
            {
                rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            }

        }

        if (FindObjectsOfType<Rock>().Any(x => x.gotPanzerHit))
        {
            KillPanzer();
        }
    }

    void KillPanzer()
    {
        Destroy(gameObject);
        Instantiate(graveStone, transform.position, transform.rotation);
    }
}