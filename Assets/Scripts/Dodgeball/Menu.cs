using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void StartCatchGame()
    {
        SceneManager.LoadScene(2);
    }

    public void StartDodgeBall()
    {
        SceneManager.LoadScene(1);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
