using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Start the game method.
    public void NewGame() { 
        SceneManager.LoadScene("Level");
    }

    //Quit game.
    public void QuitGame() {

        Application.Quit();
    }
}
