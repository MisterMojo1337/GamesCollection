using UnityEngine;
using UnityEngine.UI;

public class Mario : MonoBehaviour {

    [Header("Attributes")]
    
    public float movementForce = 5f;
    public float jumpForce = 300f;
    public float jumpCounter = 1;

    [Header("Unity Setup Fields")]
    public SpriteRenderer flipIt;

    private void FixedUpdate()
    {
        GetMovement();
    }

    public void GetMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            flipIt.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            flipIt.flipX = true;
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
    public void KillEntity(GameObject character)
    {
        Destroy(character);
    }
}
