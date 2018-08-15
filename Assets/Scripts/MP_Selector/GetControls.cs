﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Assets.Scripts.MP_Selector;
using System.Linq;
using System;

public class GetControls : MonoBehaviour {

    public InputField inpJump;
    public InputField inpLeft;
    public InputField inpRight;

    public GameObject rdyBtn;
    public GameObject unRdyBtn;

    private string jsonPath;
    private string jsonString;
    private int i = 0;
    private Control[] playerList = new Control[4];

    private void Start()
    {
        jsonPath = Application.streamingAssetsPath + "/Controls.json";
        jsonString = File.ReadAllText(jsonPath);
        playerList= JsonHelper.FromJson<Control>(jsonString);
        var objName = gameObject.name;

        foreach (var player in playerList)
        {
            if (objName == player.Id)
            {
                break;
            }
            i += 1;
        }

        JsonToTextbox(playerList[i]);
    }

    public void Ready()
    {
        rdyBtn.SetActive(false);
        unRdyBtn.SetActive(true);
        TextboxToJson();
    }

    public void NotReady()
    {
        rdyBtn.SetActive(true);
        unRdyBtn.SetActive(false);
    }

    private void TextboxToJson()
    {
        playerList[i].InputJump = inpJump.text;
        playerList[i].InputLeft = inpLeft.text;
        playerList[i].InputRight = inpRight.text;

        JsonHelper.ToJson(playerList, true);
    }

    private void JsonToTextbox(Control player)
    {
        inpJump.text = player.InputJump;
        inpLeft.text = player.InputLeft;
        inpRight.text = player.InputRight;
    }
}
