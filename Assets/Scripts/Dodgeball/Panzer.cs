using UnityEngine;
using System.Linq;

public class Panzer : BaseCharacterDB {

    private void Start()
    { 
        distToGround = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        GetMovement(KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow);

        if (gameObject.activeSelf)
        {
            timer += Time.deltaTime;
            scoreText.text = "" + timer.ToString("F2") + "";
        }
        if (FindObjectsOfType<Rock>().Any(x => x.gotPanzerHit))
        {
            healthPoints -= 50;
            if (healthPoints <= 0)
            {
                KillEntity(gameObject);
            }
        }
        if (FindObjectsOfType<Healkit>().Any(x => x.gotPanzerHeal))
        {
            healthPoints += 100;
        }
    }
}