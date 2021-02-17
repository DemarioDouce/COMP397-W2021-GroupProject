using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    //Reference to player.
    public Transform player;

    //Only update the opssition of the player only when they have move.
    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90F,player.eulerAngles.y,0F);
    }
}
