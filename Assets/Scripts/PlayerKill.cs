using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
        
}

