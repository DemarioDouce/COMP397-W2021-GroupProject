using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayPanel : MonoBehaviour
{
    //Ref to gameplay panel bg
    public GameObject GameplayPanelBg;
    //Ref to confirmationsave panel
    public  GameObject ConfirmationSavePanel;

    //Ref to confirmationload panel
    public GameObject ConfirmationLoadPanel;
    //Ref to playPause Btn
    public Text playPauseBtnTxt;

    //initializer the counter variable to hide the panel
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        GameplayPanelBg.SetActive(true);
        ConfirmationSavePanel.SetActive(false);
        ConfirmationLoadPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if condition to hide or show the panel
        if (Input.GetKeyDown(KeyCode.F1))
        {
            hidePanel();
        }
        if (PlayerManger.gameOver == true) {
            GameplayPanelBg.SetActive(false);
        }
    }

    public void Pause() {

        if (playPauseBtnTxt.text == "PAUSE")
        {
            Time.timeScale = 0;
            playPauseBtnTxt.text = "PLAY";
        }
        else {

            Time.timeScale = 1;
            playPauseBtnTxt.text = "PAUSE";
        }
        
    }

    public void Save() {

        ConfirmationSavePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Load()
    {

        ConfirmationLoadPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void NoSave() {

        ConfirmationSavePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void YesSave() {

        ConfirmationSavePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void NoLoad()
    {

        ConfirmationLoadPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void YesLoad()
    {

        ConfirmationLoadPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void hidePanel()
    {
        counter++;
        if(counter % 2 == 1)
            GameplayPanelBg.SetActive(false);
        else
            GameplayPanelBg.SetActive(true);
    }
}
