using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Object Pooling Optimization Pattern 
    public bool[] isFull;
    public GameObject[] slots;
}
