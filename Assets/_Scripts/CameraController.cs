using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //Init to the default offset between camera and player.
        offset = transform.position - target.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the new position for our camera. So it can follow the player.
        Vector3 newPosition = new Vector3(transform.position.x,transform.position.y,offset.z + target.position.z);

        //Assign new position to the transform of our main camera
        transform.position = newPosition;

    }
}
