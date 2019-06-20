using System.Collections;
using System.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour {
   
    public Transform spawnPoint;
    public GameObject rock;
    public GameObject healKit;
    public GameObject bomb;
    public bool spawning = true;

    private int playerCount;
    public float difficulty = 95f;

    void Start()
    {  
        if (spawning)
        {
            StartCoroutine(SpawnRock());
        }
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Count() != 0)
        {
            difficulty -= Time.deltaTime;
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
                } else if(spawnChance > 98)
                {
                    Instantiate(bomb, spawnPoint.position, spawnPoint.rotation);
                }
                else
                {
                    Instantiate(rock, spawnPoint.position, spawnPoint.rotation);
                }

            }            
            yield return new WaitForSeconds(spawnChance/100);
        }        
    }
}
