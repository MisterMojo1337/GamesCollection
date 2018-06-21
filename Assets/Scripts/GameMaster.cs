using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameMaster : MonoBehaviour {

    public int player = 1;
    public GameObject endScreen;

    private void Start()
    {
    }
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Gravestone").Count() == 2)
        {
            EndGame();
        }
    }
    
    void EndGame()
    {
        endScreen.SetActive(true);
    }
}
