using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        PlayerManger.numberofLifes += 1;
        Destroy(gameObject);
    }
}
