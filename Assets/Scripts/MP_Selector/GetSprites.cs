using Assets.Scripts.MP_Selector;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class GetSprites : MonoBehaviour {

    public GameObject characters;

    private SpriteRenderer[] sprites;
    private OwnSprite[] spriteList = new OwnSprite[4];
    private string spritePath;
    private string controlPath;
    

    private void Awake()
    {
        spritePath = Application.streamingAssetsPath + "/Sprites.json";

        var counter = 0;
        foreach (var jsonEntry in JsonHelper.FromJson<OwnSprite>(File.ReadAllText(spritePath)))
        {
            spriteList[counter] = jsonEntry;
            spriteList[counter].CharSprite = "";
            counter++;
        }
        var spriteToJson = JsonHelper.ToJson(spriteList, true);
        File.WriteAllText(spritePath, spriteToJson);
    }
    public void GetSprite(int playerId)
    {
        sprites = characters.GetComponentsInChildren<SpriteRenderer>(false);

        var counter = 0;
        foreach (var jsonEntry in JsonHelper.FromJson<OwnSprite>(File.ReadAllText(spritePath)))
        {
            spriteList[counter] = jsonEntry;
            counter++;
        }

        foreach (var playerSprite in sprites)
        {
            var playerSpriteString = playerSprite.sprite.ToString();
            playerSpriteString = playerSpriteString.Substring(0, playerSpriteString.LastIndexOf(' '));
            spriteList[playerId].CharSprite = playerSpriteString;
        }

        var spriteToJson = JsonHelper.ToJson(spriteList, true);
        File.WriteAllText(spritePath, spriteToJson);
    }
}
