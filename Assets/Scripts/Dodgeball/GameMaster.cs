using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts.MP_Selector;
using System.IO;
using System;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    public GameObject endScreen;
    public GameObject playerObjects;
    public GameObject maMan;
    public GameObject panzer;
    public GameObject roundyy;
    public GameObject lilBruce;

    private string controlJsonPath;
    private string spriteJsonPath;
    private int counter = 0;
    private Text playerText;
    private Image playerImage;

    [Header("Json Attribute")]
    private Control[] controls = new Control[4];
    private OwnSprite[] sprites = new OwnSprite[4];

    private void Start()
    {
        controlJsonPath = Application.streamingAssetsPath + "/Controls.json";
        spriteJsonPath = Application.streamingAssetsPath + "/Sprites.json";

        controls = JsonHelper.FromJson<Control>(File.ReadAllText(controlJsonPath));
        sprites = JsonHelper.FromJson<OwnSprite>(File.ReadAllText(spriteJsonPath));

        controls.ToList();
        sprites.ToList();

        foreach (var playerControls in controls)
        {
            //TODO make active bool
            if (playerControls.Active == 0)
            {
                var player = GameObject.Find(playerControls.Id);
                var playerCanvas = GameObject.Find(playerControls.Id + "Text");
                player.SetActive(false);
                playerCanvas.SetActive(false);
            }
            if (playerControls.Active == 1)
            {
                counter++;
                var player = GameObject.Find(playerControls.Id);
                string playerString = sprites.FirstOrDefault(x => x.Id == playerControls.Id).CharSprite;
                GameObject playerChar = GetPlayerChar(playerString);
                var playerObject = Instantiate(playerChar, player.transform.position, player.transform.rotation);
                playerObject.transform.parent = player.transform;
                
                var playerCanvas = GameObject.Find(playerControls.Id + "Text");
                player.GetComponentInChildren<CharacterControls>().playerText = playerCanvas.GetComponentInChildren<Text>();
                playerCanvas.GetComponentInChildren<Image>().sprite = playerChar.GetComponent<SpriteRenderer>().sprite;
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
            case "Lil_Bruce":
                return lilBruce;
            default:
                return maMan;
        }
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Gravestone").Count() == counter)
        {
            EndGame();
        }
    }
    
    void EndGame()
    {
        endScreen.SetActive(true);
    }
}
