using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMaster : MonoBehaviour {

    public GameObject players;
    public Text gameStart;
    public GetSprites spriteScript;

    private List<Button> rdyBtnList = new List<Button>();
    private float timer = 3.5f;
    private int counter = 0;


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
        if (AllButtonsRdy())
        {
            gameStart.gameObject.SetActive(true);
            timer -= Time.deltaTime;
            gameStart.text = "" + timer.ToString("F0") + "";
            StartGameTimer();
        } else
        {
            gameStart.gameObject.SetActive(false);
            timer = 3.5f;
        }
    }

    private void StartGameTimer()
    {

        if (timer <= 0)
        {
            foreach (var player in players.GetComponentsInChildren<GetSprites>(false))
            {
                player.GetSprite(counter);
                counter++;
            }
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
