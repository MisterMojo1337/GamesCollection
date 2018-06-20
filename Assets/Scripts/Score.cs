using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Score : MonoBehaviour {

    public LevelEnd script;
    public Text scoreText;

    private float timer;
    private string endTime;
	
	// Update is called once per frame
	void Update () {

        if (!FindObjectsOfType<Rock>().Any(x => x.gotPlayerHit))
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
