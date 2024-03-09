using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
    //puts the losemenu on the screen
    public GameObject loseMenu;
    void Update()
    {
        Time.timeScale = 0f;
        loseMenu.gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
        
}

