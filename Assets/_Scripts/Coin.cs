using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Coin
        transform.Rotate(20 * Time.deltaTime,0,0);
    }

    //Check if player pass through the coin
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            PlayerManger.numberofCoins += 1;
            Destroy(gameObject);
        }
    }
}
