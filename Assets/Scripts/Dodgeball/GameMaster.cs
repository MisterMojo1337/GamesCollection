using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts.MP_Selector;
using System.IO;
using System;

public class GameMaster : MonoBehaviour {

    public GameObject endScreen;
    public GameObject playerObjects;
    public GameObject maMan;
    public GameObject panzer;
    public GameObject roundyy;

    private string controlJsonPath;
    private string spriteJsonPath;
    private int counter = 0;
    private Control[] controls = new Control[4];
    private OwnSprite[] sprites = new OwnSprite[4];
    //private Rigidbody2D[] players = new Rigidbody2D[4];

    private void Start()
    {
        controlJsonPath = Application.streamingAssetsPath + "/Controls.json";
        spriteJsonPath = Application.streamingAssetsPath + "/Sprites.json";

        controls = JsonHelper.FromJson<Control>(File.ReadAllText(controlJsonPath));
        sprites = JsonHelper.FromJson<OwnSprite>(File.ReadAllText(spriteJsonPath));
        //var players = playerObjects.GetComponentsInChildren<Rigidbody2D>(true);

        controls.ToList();
        sprites.ToList();

        foreach (var playerControls in controls)
        {
            //TODO make active bool
            if (playerControls.Active == 0)
            {
                var player = GameObject.Find(playerControls.Id);
                player.SetActive(false);
            }
            if (playerControls.Active == 1)
            {
                counter++;
                var player = GameObject.Find(playerControls.Id);
                string playerString = sprites.FirstOrDefault(x => x.Id == playerControls.Id).CharSprite;
                GameObject playerChar = GetPlayerChar(playerString);
                var temp = Instantiate(playerChar, player.transform.position, player.transform.rotation);
                temp.transform.parent = player.transform;
            }
        }
    }

    private GameObject GetPlayerChar(string playerString)
    {
        switch (playerString)
        {
            case "Ma_man":
                return maMan;
            case "Panzer":
                return panzer;
            case "Roundyy":
                return roundyy;
            default:
                return maMan;
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
