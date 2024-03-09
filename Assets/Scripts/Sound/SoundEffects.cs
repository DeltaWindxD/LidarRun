using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;

    //plays sound when button is pressed

    public void Button()
    {
        src.clip = sfx;
        src.Play();
    }
}
