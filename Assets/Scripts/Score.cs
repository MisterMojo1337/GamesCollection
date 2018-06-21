using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Score : MonoBehaviour {

    public LevelEnd script;
    public Text scoreText;

    private float timer;
    private string endTime;
    private bool gotPlayerHit;
    private bool gotpanzerHit;

    
    // Update is called once per frame
    void Update () {

        if (GameObject.FindGameObjectsWithTag("Gravestone").Count() != 2)
        {
            endTime = Timer();
        } else
        {
            script.Anzeige(endTime);
        }
	}
    
    string Timer()
    { 
        timer += Time.deltaTime;
        scoreText.text = "" + timer.ToString("F2") + "";
        return timer.ToString("F2");
    }
}
