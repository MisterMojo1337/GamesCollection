using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public SceneMaster sceneMaster;

    public void Start()
    {
        
    }
    public void StartCatchGame()
    {
        sceneMaster.GetSceneName("CatchGame");
        SceneManager.LoadScene("MultiplayerOptions");
    }

    public void StartClimbDaTower()
    {
        sceneMaster.GetSceneName("ClimbDaTower");
        SceneManager.LoadScene("MultiplayerOptions");
    }

    public void StartDodgeBall()
    {
        sceneMaster.GetSceneName("DodgeBall");
        SceneManager.LoadScene("MultiplayerOptions");
    }

    public void GoMainMenu()
    {
        SceneManager.GetSceneByName("StartScreen");
    }
}
