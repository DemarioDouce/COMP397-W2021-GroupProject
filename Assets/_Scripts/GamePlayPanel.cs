using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayPanel : MonoBehaviour
{
    //Ref to gameplay panel bg
    public GameObject GameplayPanelBg;
    //Ref to playPause Btn
    public Text playPauseBtnTxt;


    // Start is called before the first frame update
    void Start()
    {
        GameplayPanelBg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManger.isGameStarted == true)
        {
            GameplayPanelBg.SetActive(true);

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
}
