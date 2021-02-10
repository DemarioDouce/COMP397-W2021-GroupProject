using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{


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
        Volume();
    }

    public void PlaySound(string name) {

        foreach (Sound s in sounds)
        {

            if (s.name == name) {

                s.source.Play();
                s.source.volume = OptionsMenu.volume;

            }

        }

    }

     void Update()
    {
        Volume();
    }

    //Control volume using slider.
    public void Volume()
    {

        foreach (Sound s in sounds)
        {

            s.source.volume =OptionsMenu.volume;
            s.volume = OptionsMenu.volume;

        }

    }    
}
