using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeypadInteractor : MonoBehaviour, IInteractable
{

    //Pauses the rest of the game except the keypad which now gets showed
    public GameObject KeypadManager;
    public void Interact() {
        KeypadManager.SetActive(true);
        Time.timeScale = 0f;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}

