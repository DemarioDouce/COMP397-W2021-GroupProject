using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    //Hold the ground prefabs and the array amount.
    public GameObject[] groundPrefabs;

    //Hold current ground
    private List<GameObject> activeGround = new List<GameObject>();

    //Number of time it will spawn on the z axis.
    public float zSpawn = 0;

    //Length of ground prefabs
    private float groundLength = 9;

    //Number of ground we wanna see on the screen.
    private int numberOfGround = 10;

    //Get the player
    public Transform playerTransform;

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

        if (playerTransform.position.z - 10 > zSpawn - numberOfGround * groundLength) {

            spawnGround(Random.Range(0, groundPrefabs.Length));

            DeleteGround();

        }
        
    }

    //Spawn ground method.
    public void spawnGround(int groundIndex) {

       GameObject go = Instantiate(groundPrefabs[groundIndex],transform.forward * zSpawn, transform.rotation);
        activeGround.Add(go);
        zSpawn += groundLength;
    }

    //Delete ground.
    private void DeleteGround() {

        Destroy(activeGround[0]);
        activeGround.RemoveAt(0);
    }
}
