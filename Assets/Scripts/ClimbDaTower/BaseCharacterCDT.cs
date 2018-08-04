using UnityEngine;
using UnityEngine.UI;

public abstract class BaseCharacterCDT : MonoBehaviour {

    [Header("Attributes")]
    
    public float movementForce = 5f;
    public float jumpForce = 300f;

    [Header("Unity Setup Fields")]
    public Rigidbody2D rb;   
    public SpriteRenderer flipIt;
    public float distToPlatform;



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
            if (distToPlatform + 0.1 >= transform.position.y)
            {
                rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            }
        }
    }
    public void KillEntity(GameObject character)
    {
        Destroy(character);
    }
}
