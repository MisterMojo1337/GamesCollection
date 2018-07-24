using UnityEngine;
using UnityEngine.UI;

public abstract class BaseCharacter : MonoBehaviour {

    [Header("Attributes")]

    public float healthPoints = 100f;
    public float movementForce = 5f;
    public float jumpForce = 300f;

    [Header("Unity Setup Fields")]
    public GameObject graveStone;
    public Rigidbody2D rb;   
    public Text scoreText;
    public SpriteRenderer flipIt;
    public float timer;
    public float distToGround;



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
            if (distToGround + 0.1 >= transform.position.y)
            {
                rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            }
        }
    }
    public void KillEntity(GameObject character)
    {
        Destroy(character);
        Instantiate(graveStone, character.transform.position, character.transform.rotation);
    }
}
