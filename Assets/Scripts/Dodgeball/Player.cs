using UnityEngine;
using System.Linq;

public class Player : BaseCharacterDB {


    private void Start()
    {
        distToGround = transform.position.y;
    }

    private void Update()
    {
        if (gameObject.activeSelf)
        {
            timer += Time.deltaTime;
            scoreText.text = "" + timer.ToString("F2") + "";
        }
        if (FindObjectsOfType<Rock>().Any(x => x.gotPlayerHit))
        {
            healthPoints -= 50;
            if (healthPoints <= 0)
            {
                KillEntity(gameObject);
            }
        }
        if (FindObjectsOfType<Healkit>().Any(x => x.gotPlayerHeal))
        {
            healthPoints += 100;
        }
    }
    void FixedUpdate () {

        GetMovement(KeyCode.A, KeyCode.D, KeyCode.W);
        
    }
}
