using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Ref to main canvas.
    public GameObject MainCanvas;
    //Ref to options canvas.
    public GameObject OptionsCanvas;
    //Start the game method.
    public void NewGame() { 
        SceneManager.LoadScene("Level");
    }

    //Quit game.
    public void QuitGame() {

        Application.Quit();
    }

    //Options
    public void Options() {
        OptionsCanvas.SetActive(true);
        MainCanvas.SetActive(false);
    }

    //Go back
    public void GoBack()
    {
        OptionsCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
}
