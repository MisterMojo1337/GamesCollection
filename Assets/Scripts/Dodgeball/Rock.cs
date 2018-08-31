using UnityEngine;

public class Rock : BaseObjectDB {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Character")
        {
            gotPlayerHit = true;
        }
        if (collision.transform.name == "Panzer")
        {
            gotPanzerHit = true;
        }
        Instantiate(particles, transform.position - new Vector3(0.1f, 0.1f), transform.rotation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
