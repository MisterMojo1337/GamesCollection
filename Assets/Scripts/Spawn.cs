using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private float countdown = 1f;

    public Transform spawnPoint;
    public GameObject rock;
    

    void Start()
    {
        StartCoroutine(SpawnRock());
    }

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnRock();
        }

        countdown -= Time.deltaTime;
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
