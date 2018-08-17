using Assets.Scripts.MP_Selector;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class GetSprites : MonoBehaviour {

    public GameObject characters;

    private SpriteRenderer[] sprites;
    private List<OwnSprite> spriteList = new List<OwnSprite>();
    private string spritePath;
    private string controlPath;

    private void Start()
    {
        spritePath = Application.streamingAssetsPath + "/Sprites.json";
        controlPath = Application.streamingAssetsPath + "/Controls.json";
        GetSprite();
    }
    public void GetSprite()
    {
        sprites = characters.GetComponentsInChildren<SpriteRenderer>(false);
        var controlsEntry = JsonHelper.FromJson<Control>(File.ReadAllText(controlPath));
        var counter = controlsEntry.Where(x => x.Active == 1).Count();



        //var spriteToJson = JsonHelper.ToJson(spriteList, true);
        //File.WriteAllText(spritePath, spriteToJson);
    }
}
