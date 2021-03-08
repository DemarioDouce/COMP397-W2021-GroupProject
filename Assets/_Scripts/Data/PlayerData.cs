using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make us able to save it inside a file.
[System.Serializable]
public class PlayerData
{
    public int numberofCoins;

    public int numberofLifes;


    //Take in the data from our player.
    public PlayerData(PlayerManger playerManger) {

        numberofCoins = playerManger.numberofCoinsRef;
        numberofLifes = playerManger.numberofLifesRef;
    //    position = new float[3];
     //   position[0] = PlayerController.direction.x;
     //  position[1] = PlayerController.direction.y;
       // position[2] = PlayerController.direction.z;


    }
}
