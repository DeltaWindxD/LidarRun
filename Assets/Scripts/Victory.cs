using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "ExitDoor")
        {
                Time.timeScale = 0f;
            GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
