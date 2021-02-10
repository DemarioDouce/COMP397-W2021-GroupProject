using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    //Ref slider
    public Slider volumeSlider;
    public static float volume;

     void Start()
    {
        volume = 0.68F;
        volumeSlider.value = volume;
    }

    //Control volume using slider.
    public void Volume()
    {

        volume = volumeSlider.value;

    }
}
