using UnityEngine;

public class Healkit : BaseObjectDB {
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Character")
        {
            gotPlayerHeal = true;
        }
        if (collision.transform.name == "Panzer")
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
