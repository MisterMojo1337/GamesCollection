using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts.MP_Selector;
using System.IO;

public class GameMaster : MonoBehaviour {

    public GameObject endScreen;
    public GameObject players;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    private int player;
    private string controlPath;
    private string spritePath;
    private void Start()
    {
        controlPath = Application.streamingAssetsPath + "/Controls.json";
        spritePath = Application.streamingAssetsPath + "/Sprites.json";

        var controls = JsonHelper.FromJson<Control>(File.ReadAllText(controlPath));
        var sprites = JsonHelper.FromJson<OwnSprite>(File.ReadAllText(spritePath));
        var temp = players.GetComponentsInChildren<Rigidbody2D>(true);

        foreach (var character in controls)
        {
            if (character.Active == 1)
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
