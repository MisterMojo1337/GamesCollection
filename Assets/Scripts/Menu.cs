using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void StartCatchGame()
    {
        SceneManager.GetSceneByBuildIndex(2);
    }

    public void StartClimbDaTower()
    {
        SceneManager.GetSceneByBuildIndex(3);
    }

    public void StartDodgeBall()
    {
        SceneManager.GetSceneByBuildIndex(1);
    }

    public void GoMainMenu()
    {
        SceneManager.GetSceneByBuildIndex(0);
    }
}
