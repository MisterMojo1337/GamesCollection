using UnityEngine;
using UnityEngine.UI;

public class Mario : MonoBehaviour {

    [Header("Attributes")]
    
    public float movementForce = 5f;
    public float jumpForce = 300f;
    public float jumpCounter = 1;

    private float maxHeight;

    private void Start()
    {
        maxHeight = gameObject.transform.position.y;
    }
    private void FixedUpdate()
    {
        GetMovement();
    }

    private void Update()
    {
        if (gameObject.transform.position.y > maxHeight)
        {
            maxHeight = gameObject.transform.position.y;
        } else if (gameObject.transform.position.y < maxHeight - 7){
            Destroy(gameObject);
        }
    }

    public void GetMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (jumpCounter > 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce * Time.deltaTime);
                jumpCounter--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Plane")
        {
            jumpCounter = 1;
        }
    }
}
