using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour, IInteractable 
{ 

    [SerializeField] private Animator Door;
    [SerializeField] private Animator Door2;
    //Starts the animtion of the doors and makes them visible
    public void Interact()
    {
        Door.SetBool("Open", true);
        Door2.SetBool("Open", true);
        GameObject.Find("Door").layer = 0;
        GameObject.Find("Door2").layer = 0;
    }
}
