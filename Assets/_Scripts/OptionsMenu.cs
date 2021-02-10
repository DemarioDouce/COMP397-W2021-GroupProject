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
    }

    //Control volume using slider.
    public void Volume()
    {

        volume = volumeSlider.value;

    }

    
    //Control up arrow dropdown.
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
    public void DownArrowDropdown()
    {
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
        else
        {

            upArrowKey = KeyCode.UpArrow;
        }
    }
}
