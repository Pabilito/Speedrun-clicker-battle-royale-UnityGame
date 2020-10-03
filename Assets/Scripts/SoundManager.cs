using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public static bool soundOn = true;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(instance);
        if (!soundOn)
        {
            this.GetComponent<AudioSource>().Pause();
        }

    }

    public void muteOrUnmute()
    {
        if (soundOn)
        {
            this.GetComponent<AudioSource>().Pause();
        }
        else
        {
            this.GetComponent<AudioSource>().Play();
        }
        soundOn = !soundOn;
    }

}
