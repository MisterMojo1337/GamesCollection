using Assets.Scripts.MP_Selector;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class GetSprites : MonoBehaviour {

    public GameObject Characters;

    private SpriteRenderer[] sprites;
    private List<OwnSprite> spriteList = new List<OwnSprite>();
    private string jsonPath;

    private void Start()
    {
        jsonPath = Application.streamingAssetsPath + "/Sprites.json";
        GetSprite();
    }
    public void GetSprite()
    {
        sprites = Characters.GetComponentsInChildren<SpriteRenderer>(false);
        var counter = 0;

        

        //var spriteToJson = JsonHelper.ToJson(spriteList, true);
        //File.WriteAllText(jsonPath, spriteToJson);
    }
}
