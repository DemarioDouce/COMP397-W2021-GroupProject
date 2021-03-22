using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManger : MonoBehaviour
{

    [Header("Player Settings")]
    public CameraController playerCamera;
    public PlayerController player;


    [Header("Scene Data")]
    public SceneDataSO sceneData;

    //Trial ref
    public int numberofCoinsRef;
    public int numberofLifesRef;

    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public GameObject gameOverText;

    //Keep track of coins
    public static int numberofCoins = 0;
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
        playerCamera = FindObjectOfType<CameraController>();
        player = FindObjectOfType<PlayerController>();
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

        //Ref
        numberofCoinsRef = numberofCoins;
        numberofLifesRef = numberofLifes;
        //Starts the game.
        if (Input.GetKeyDown(KeyCode.Space) || SwipeManager.tap) {

            isGameStarted = true;
            Destroy(startingText);
        }
    }

    public void SavePlayer()
    {

        //SaveSystem.SavePlayer(this);
        sceneData.playerPosition = player.transform.position;
        Debug.Log("Position saved into SO = "+player.transform.position);
        sceneData.playerCoins = numberofCoins;
        sceneData.playerLives = numberofLifes;
    }

    public void LoadPlayer()
    {
        int actualLife = sceneData.playerLives;
        int actualCoins = sceneData.playerCoins;
        Debug.Log("Position before load = "+player.transform.position);
        player.controller.enabled = false;
        player.transform.position = sceneData.playerPosition;
        player.controller.enabled = true;
        Debug.Log("Position after load = " + player.transform.position);

        numberofLifes = actualLife;
        numberofCoins = actualCoins;
        

        //old code
        /*PlayerData data = SaveSystem.LoadPlayer();
        numberofCoins = data.numberofCoins;
        numberofLifes = data.numberofLifes;*/
    }
}
