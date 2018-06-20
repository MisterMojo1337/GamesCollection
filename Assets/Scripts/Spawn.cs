using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour {
   
    public Transform spawnPoint;
    public GameObject rock;
    public bool spawning = true;
    
    void Start()
    {
        if (spawning)
        {
            StartCoroutine(SpawnRock());
        }
    }

    IEnumerator SpawnRock()
    {
        while (true)
        {
            var temp = Random.value;
            var temp2 = temp * 100;
            if (temp2 > 90)
            {
                Instantiate(rock, spawnPoint.position, spawnPoint.rotation);
            }            
            yield return new WaitForSeconds(temp);
        }
        
    }
}
