using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void StartCatchGame()
    {
        SceneManager.GetSceneByName("CatchGame");
    }

    public void StartClimbDaTower()
    {
        SceneManager.GetSceneByName("ClimbDaTower");
    }

    public void StartDodgeBall()
    {
        SceneManager.GetSceneByName("DodgeBall");
    }

    public void GoMainMenu()
    {
        SceneManager.GetSceneByName("CatchGame");
    }
}
