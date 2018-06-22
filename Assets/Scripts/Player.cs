using UnityEngine;
using System.Linq;

public class Player : BaseCharacter {


    private void Start()
    {
        distToGround = transform.position.y;
    }
    
    void Update () {

        GetMovement(KeyCode.A, KeyCode.D, KeyCode.W);

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
}
