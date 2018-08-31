using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Char_Select : MonoBehaviour {

    private List<GameObject> list = new List<GameObject>();
    private int listCounter = 0;
    //private List<Sprite> spriteList;

    //public GameObject characters;
    public GameObject maMan;
    public GameObject panzer;
    public GameObject roundy;

    private void Awake()
    {

        list.Add(maMan);
        list.Add(panzer);
        list.Add(roundy);
        ShowSprite();
    }
    public void GetNextChar()
    {
        list[listCounter].SetActive(false);
        listCounter += 1;
        if (listCounter > 2)
        {
            listCounter = 0;
        }
        ShowSprite();
    }

    public void GetPreviousChar()
    {
        list[listCounter].SetActive(false);
        listCounter -= 1;
        if (listCounter < 0)
        {
            listCounter = 2;
        }
        ShowSprite();
    }
    private void ShowSprite()
    {
        list[listCounter].SetActive(true);
    }
}
