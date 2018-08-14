using UnityEngine;
using UnityEngine.UI;

public abstract class BaseCharacterCDT : MonoBehaviour {

    [Header("Attributes")]
    
    public float movementForce = 5f;
    public float jumpForce = 300f;
    public float jumpCounter = 1;

    [Header("Unity Setup Fields")]
    public Rigidbody2D rb;   
    public SpriteRenderer flipIt;



    public void GetMovement(KeyCode left, KeyCode right, KeyCode up)
    {
        if (Input.GetKey(right))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            flipIt.flipX = true;
        }
        if (Input.GetKey(left))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            flipIt.flipX = false;
        }
        if (Input.GetKey(up))
        {
            if (jumpCounter > 0)
            {
                rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
                jumpCounter -= 1;
            }
        }
    }
    public void KillEntity(GameObject character)
    {
        Destroy(character);
    }
}
