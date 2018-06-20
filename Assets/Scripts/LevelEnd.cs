using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour {

    public Text text;
    public GameObject score;

    public void Anzeige(string endTime)
    {
        text.text = "Sie haben " + endTime + "sek durchgehalten";

        score.SetActive(false);
    }

}
