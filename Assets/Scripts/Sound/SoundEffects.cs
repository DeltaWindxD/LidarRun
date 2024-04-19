using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;

    //plays sound when button is pressed

    public void Button()
    {
        src.Play();
    }
}
