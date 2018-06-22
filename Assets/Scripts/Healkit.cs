using UnityEngine;

public class Healkit : BaseObject {
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gotPlayerHeal = true;
        }
        if (collision.CompareTag("Panzer"))
        {
            gotPanzerHeal = true;
        }
        Instantiate(particles, transform.position - new Vector3(0.1f, 0.1f), transform.rotation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
