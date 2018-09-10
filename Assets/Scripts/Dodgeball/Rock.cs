using UnityEngine;

public class Rock : MonoBehaviour {
    
    public GameObject particles;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInChildren<CharacterControls>() != null)
        {
            collision.GetComponentInChildren<CharacterControls>().healthPoints -= 50;
        }

        Instantiate(particles, transform.position - new Vector3(0.1f, 0.1f), transform.rotation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
