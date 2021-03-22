using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{

    //Deals with the game over panel button click functions.

    public void ReplayGame()
    {
        SceneManager.LoadScene("Level");
        PlayerManger.numberofCoins = 0;
        PlayerManger.numberofLifes = 3;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
