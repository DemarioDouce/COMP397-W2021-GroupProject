using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //A CharacterController allows you
    //to easily do movement constrained by collisions without having to deal with a rigidbody.
    private CharacterController controller;

    //Where the player is going.
    private Vector3 direction;

    //How fast the player will move forward.
    private float forwardSpeed = 10;
    //Max speed
    private float maxSpeed = 15;

    //Lane movement.
    private int desiredLane = 1; // 1 = Middle lane. 0 - Left lane. 2 - Right lane.

    //The distance between two lanes.
    private float laneDistance = 3.0f;

    //Set jump force.
    private float jumpForce = 10;

    //Set gravity
    private float gravity = -20;

    //Ref for animator.
    public Animator animator;

    //Sliding
    private bool isSliding = false;
    //Start is called before the first frame update.
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    //Update is called once per frame.
    void Update()
    {
        if (!PlayerManger.isGameStarted) {

            return;
        }

        //Increase speed.
        if (forwardSpeed < maxSpeed)
        {
            forwardSpeed += 0.1F * Time.deltaTime;
        }
        else { 
        
        
        }
       
        animator.SetBool("isGameStarted",true);
        //Set the z axis to the forwardspeed.
        direction.z = forwardSpeed;
        //Check if the player is on the ground.
        if (controller.isGrounded) {
            direction.y = -1;
            //Allow player to jump.
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetBool("isGrounded", false);
                Jump();
            }
        } else if (!controller.isGrounded) {
            //Affect the player by gravity.
            animator.SetBool("isGrounded",true);

            direction.y += gravity * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && !isSliding) {

            StartCoroutine(Slide());
        }

        //Get input on which lane we should be.
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            desiredLane++;
            if (desiredLane == 3) {
                desiredLane = 2;
            }
                }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }

        //Calculate where we should be using the default lane value.
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0) {
            targetPosition += Vector3.left * laneDistance;
        } else if (desiredLane == 2) {
            targetPosition += Vector3.right * laneDistance;
        }

        
        transform.position = targetPosition;


        //Fix olayer going through obstacles.
      

    }

    private void FixedUpdate()
    {

        if (!PlayerManger.isGameStarted)
        {

            return;
        }
        //The interval in seconds at which physics 
        //and other fixed frame rate updates (like MonoBehaviour's FixedUpdate) are performed.
        controller.Move(direction * Time.fixedDeltaTime);
    }

    //Allow player to jump.
    private void Jump() {

        direction.y = jumpForce;
    
    }

    //Check if it collid with tags with the name obstacles.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle") {

           PlayerManger.numberofLifes -= 1;
            FindObjectOfType<AudioManager>().PlaySound("Life hit");


            if (PlayerManger.numberofLifes == 0) {
                PlayerManger.gameOver = true;
                FindObjectOfType<AudioManager>().PlaySound("GameOver");
            }

        
        }
    }

    private IEnumerator Slide() {

        isSliding = true;
        animator.SetBool("isSliding",true);
        controller.center = new Vector3(0,-0.5F,0);
        controller.height = 1;
        yield return new WaitForSeconds(1.3F);
        controller.center = new Vector3(0, 0, 0);
        controller.height = 2;
        animator.SetBool("isSliding", false);
        isSliding = false;


    }
}
