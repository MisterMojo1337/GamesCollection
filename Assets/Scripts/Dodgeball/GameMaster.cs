using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts.MP_Selector;
using System.IO;

public class GameMaster : MonoBehaviour {

    public GameObject endScreen;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    private int player;
    private string jsonPath;
    private void Start()
    {
        jsonPath = Application.streamingAssetsPath + "/Controls.json";
        var temp = JsonHelper.FromJson<Control>(File.ReadAllText(jsonPath));

        foreach (var character in temp)
        {
            if (true)
            {
                player++;
            }
        }


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
