using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void StartCatchGame()
    {
        SceneManager.LoadScene("CatchGame");
    }

    public void StartDodgeBall()
    {
        SceneManager.LoadScene("DodgeBall");
    }
}
