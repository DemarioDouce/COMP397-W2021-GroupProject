using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    //Ref slider
    public Slider volumeSlider;
    public Sound[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Sound s in sounds) {

          s.source =   gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;

        }

        PlaySound("GamePlay");
    }

    public void PlaySound(string name) {

        foreach (Sound s in sounds)
        {

            if (s.name == name) {

                s.source.Play();
            
            }

        }

    }

    //Control volume using slider.
    public void Volume()
    {

        foreach (Sound s in sounds)
        {

            s.volume = volumeSlider.value;

        }

    }
}
