using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMaster : MonoBehaviour {

    //public GetSprites spriteScriptP1;
    //public GetSprites spriteScriptP2;
    //public GetSprites spriteScriptP3;
    //public GetSprites spriteScriptP4;
    public GameObject players;
    public Text gameStart;

    private List<Button> rdyBtnList = new List<Button>();
    private float timer = 3f;


    private void Start()
    {
        var sceneBtnList = players.GetComponentsInChildren<Button>(true);
        foreach (var button in sceneBtnList)
        {
            if (button.name == "RdyButton")
            {
                rdyBtnList.Add(button);
            }
        }
        StartCoroutine(WhenBtnsRdy());
    }

    private IEnumerator WhenBtnsRdy()
    {
        while (true)
        {            
            if (AllButtonsRdy())
            {
                StartGameTimer();
                StopCoroutine(WhenBtnsRdy());
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void Update()
    {
        if (gameStart.IsActive())
        {
            timer -= Time.deltaTime;
            gameStart.text = "" + timer.ToString("F0") + "";
            StartGameTimer();
        }
    }

    private void StartGameTimer()
    {
        gameStart.gameObject.SetActive(true);
        if (timer <= 0)
        {
            var scriptList = players.GetComponentsInChildren<GetSprites>(true);
            SceneManager.LoadScene("Dodgeball");
        }
    }

    private bool AllButtonsRdy()
    {
        var counter = 0;
        foreach (var button in rdyBtnList)
        {
            if (!button.IsActive())
            {
                counter++;
            }           
        }
        if (counter == rdyBtnList.Count)
        {
            return true;
        }
        return false;
    }
}
