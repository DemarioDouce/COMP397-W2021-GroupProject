using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    CharacterController _controller;
    Transform target;
    GameObject Player;
    Vector3 movement;


    float _moveSpeed = PlayerController.forwardSpeed -0.1F;


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

        if (Player.transform.position.x == 3)
        {
            movement.x = direction.x;
        }
        else if (Player.transform.position.x == -3)
        {

            movement.x = direction.x;
        }
        else { movement.x = 0; }


        

        Vector3 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);


    }

    private void FixedUpdate()
    {

        if (!PlayerManger.isGameStarted)
        {

            return;
        }
        //The interval in seconds at which physics 
        //and other fixed frame rate updates (like MonoBehaviour's FixedUpdate) are performed.
        _controller.Move(movement);
    }

    //Check if it collid with tags with the name obstacles.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {

         
            Destroy(hit.gameObject);


            


        }
        else if (hit.transform.tag == "Player") {

            PlayerManger.numberofLifes = 0;

            if (PlayerManger.numberofLifes == 0)
            {
                PlayerManger.gameOver = true;
                FindObjectOfType<AudioManager>().PlaySound("GameOver");
            }

        }
    }
}
