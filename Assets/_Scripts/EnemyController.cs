using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    CharacterController _controller;
    Transform target;
    GameObject Player;


    float _moveSpeed = PlayerController.forwardSpeed -0.40F;


    // Use this for initialization
    void Start()
    {


        Player = GameObject.FindWithTag("Player");
        target = Player.transform;



        _controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManger.isGameStarted)
        {

            return;
        }

        Vector3 direction = target.position - transform.position;

        direction = direction.normalized;

        Vector3 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);


    }

    //Check if it collid with tags with the name obstacles.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {

         
            Destroy(hit.gameObject);


            


        }
        else if (hit.transform.tag == "Player") {

            PlayerManger.numberofLifes -= 1;

            if (PlayerManger.numberofLifes == 0)
            {
                PlayerManger.gameOver = true;
                FindObjectOfType<AudioManager>().PlaySound("GameOver");
            }

        }
    }
}
