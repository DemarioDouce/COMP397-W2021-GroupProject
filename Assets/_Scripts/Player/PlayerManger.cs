using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManger : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public GameObject gameOverText;

    //Keep track of coins
    public static int numberofCoins;
    //Ref of the text for coins
    public Text coinsText;

    //Keep track of players life
    public static int numberofLifes = 3;
    //Ref of the text for life
    public Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberofCoins = 0;
        numberofLifes = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //Deals with the game over panel.
        if (gameOver) {

            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        //Keep track of the coin count.
        coinsText.text = "Coins: " +numberofCoins;

        //Keep track of the life count.
        lifeText.text = "Lifes: " + numberofLifes;

        //Starts the game.
        if (Input.GetKeyDown(KeyCode.Space)) {

            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
