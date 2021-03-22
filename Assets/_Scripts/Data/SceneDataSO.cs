using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ScenaData", menuName ="Data/SceneData")]
public class SceneDataSO : ScriptableObject
{

    //Player Data
    [Header("Player Data")]
    public Vector3 playerPosition;
    public int playerLives;
    public int playerCoins;


   
}
