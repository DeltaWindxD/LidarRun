using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractor : MonoBehaviour, IInteractable {
    public GameObject KeypadManager;
    public void Interact() {
        KeypadManager.SetActive(true);
        Time.timeScale = 0f;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
