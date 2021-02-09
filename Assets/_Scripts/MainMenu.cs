using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Ref to main canvas.
    public GameObject MainCanvas;
    //Ref to load game canvas.
    public GameObject LoadGameCanvas;
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

    //Load game 
    public void LoadGame()
    {
        LoadGameCanvas.SetActive(true);
        MainCanvas.SetActive(false);
    }

    //Go back
    public void GoBack()
    {
        LoadGameCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
}
