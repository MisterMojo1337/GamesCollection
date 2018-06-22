using System.Collections;
using System.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour {
   
    public Transform spawnPoint;
    public GameObject rock;
    public GameObject healKit;
    public bool spawning = true;

    public float difficulty = 95f;

    void Start()
    {
        if (spawning)
        {
            StartCoroutine(SpawnRock());
            StartCoroutine(GetDifficulty());
        }
    }

    IEnumerator SpawnRock()
    {
        while (true)
        {
            var temp = Random.value;
            var temp2 = temp * 100;
            if (temp2 > difficulty)
            {
                if (temp2 > 99.5)
                {
                    Instantiate(healKit, transform.position, transform.rotation);
                } else
                {
                    Instantiate(rock, spawnPoint.position, spawnPoint.rotation);
                }
            }            
            yield return new WaitForSeconds(temp);
        }        
    }

    IEnumerator GetDifficulty()
    {
        while (FindObjectsOfType<Player>().Count() >= 1)
        {
            difficulty -= 1f;
            yield return new WaitForSeconds(1);
        }
    }
}
