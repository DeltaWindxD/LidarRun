using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StarterAssets;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    public void Stop()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void Play()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    public void MainMenuButton()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
