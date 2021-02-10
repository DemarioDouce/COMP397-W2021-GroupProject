using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    //Ref slider
    public Slider volumeSlider;
    //Ref up arrow drop down.
    public Dropdown upArrowDdn;
    //Ref down arrow drop down.
    public Dropdown downArrowDdn;
    //Ref left arrow drop down.
    public Dropdown leftArrowDdn;
    //Ref right arrow drop down.
    public Dropdown rightArrowDdn;
    public static KeyCode upArrowKey;
    public static KeyCode downArrowKey;
    public static KeyCode leftArrowKey;
    public static KeyCode rightArrowKey;
    public static float volume;

     void Start()
    {
        volume = 0.68F;
        volumeSlider.value = volume;
        upArrowKey = KeyCode.UpArrow;
        downArrowKey = KeyCode.DownArrow;
        leftArrowKey = KeyCode.LeftArrow;
        rightArrowKey = KeyCode.RightArrow;
    }

     void Update()
    {
        UpArrowDropdown();
        DownArrowDropdown();
        LeftArrowDropdown();
        RightArrowDropdown();
    }

    //Control volume using slider.
    public void Volume()
    {

        volume = volumeSlider.value;

    }

    
    //Control up arrow dropdown.
    //ABCD
    public void UpArrowDropdown() {
        if (upArrowDdn.value == 1)
        {

            upArrowKey = KeyCode.A;
            
        }
        else if (upArrowDdn.value == 2)
        {

            upArrowKey = KeyCode.B;
          
        }
        else if (upArrowDdn.value == 3)
        {

            upArrowKey = KeyCode.C;
        }
        else if (upArrowDdn.value == 4)
        {
            upArrowKey = KeyCode.D;
        }
        else {

            upArrowKey = KeyCode.UpArrow;
        }
    }

    //Control down arrow dropdown.
    //EFGH
    public void DownArrowDropdown()
    {
        if (downArrowDdn.value == 1)
        {

            downArrowKey = KeyCode.E;

        }
        else if (downArrowDdn.value == 2)
        {

            downArrowKey = KeyCode.F;

        }
        else if (downArrowDdn.value == 3)
        {

            downArrowKey = KeyCode.G;
        }
        else if (downArrowDdn.value == 4)
        {
            downArrowKey = KeyCode.H;
        }
        else
        {

            downArrowKey = KeyCode.DownArrow;
        }
    }

    //Control left arrow dropdown.
    //IJKL MOPQ
    public void LeftArrowDropdown()
    {
        if (leftArrowDdn.value == 1)
        {

            leftArrowKey = KeyCode.I;

        }
        else if (leftArrowDdn.value == 2)
        {

            leftArrowKey = KeyCode.J;

        }
        else if (leftArrowDdn.value == 3)
        {

            leftArrowKey = KeyCode.K;
        }
        else if (leftArrowDdn.value == 4)
        {
            leftArrowKey = KeyCode.L;
        }
        else
        {

            leftArrowKey = KeyCode.LeftArrow;
        }
    }

    //Control right arrow dropdown.
    //MOPQ
    public void RightArrowDropdown()
    {
        if (rightArrowDdn.value == 1)
        {

            rightArrowKey = KeyCode.M;

        }
        else if (rightArrowDdn.value == 2)
        {

            rightArrowKey = KeyCode.O;

        }
        else if (rightArrowDdn.value == 3)
        {

            rightArrowKey = KeyCode.P;
        }
        else if (rightArrowDdn.value == 4)
        {
            rightArrowKey = KeyCode.Q;
        }
        else
        {

            rightArrowKey = KeyCode.RightArrow;
        }
    }
}
