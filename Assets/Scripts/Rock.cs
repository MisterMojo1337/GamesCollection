using UnityEngine;

public class Rock : MonoBehaviour {

    public bool gotPlayerHit = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gotPlayerHit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
