
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
            var spawnChance = Random.value * 100;
            if (spawnChance > difficulty)
            {
                if (spawnChance > 99.5)
                {
                    Instantiate(healKit, transform.position, transform.rotation);
                } else
                {
                    Instantiate(rock, spawnPoint.position, spawnPoint.rotation);
                }
            }            
            yield return new WaitForSeconds(spawnChance/100);
        }        
    }

    IEnumerator GetDifficulty()
    {
        while (GameObject.FindGameObjectsWithTag("Player").Count() >= 1)
        {
            difficulty -= 1f;
            yield return new WaitForSeconds(1);
        }
    }
}
