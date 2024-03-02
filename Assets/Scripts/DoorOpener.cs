using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour, IInteractable 
{ 

    [SerializeField] private Animator Door;
    [SerializeField] private Animator Door2;
    // Start is called before the first frame update
    public void Interact()
    {
        Door.SetBool("Open", true);
        Door2.SetBool("Open", true);
        GameObject.Find("Door").layer = 0;
        GameObject.Find("Door2").layer = 0;
    }
}
