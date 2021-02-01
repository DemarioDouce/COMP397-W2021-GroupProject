using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    //Hold the ground prefabs and the array amount.
    public GameObject[] groundPrefabs;

    //Number of time it will spawn on the z axis.
    public float zSpawn = 0;

    //Length of ground prefabs
    private float groundLength = 9;

    //Number of ground we wanna see on the screen.
    private int numberOfGround = 50;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfGround; i++)
        {
            if (i == 0)
            {
                spawnGround(0);
            } else {

                spawnGround(Random.Range(0, groundPrefabs.Length));
            }
            
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn title method.
    public void spawnGround(int groundIndex) {

        Instantiate(groundPrefabs[groundIndex],transform.forward * zSpawn, transform.rotation);
        zSpawn += groundLength;
    }
}
