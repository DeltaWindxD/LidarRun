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

    //checks if player pressed escape
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
    
    //Pauses the game and shows pause menu
    public void Stop()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
    }

    //Unpauses the game
    public void Play()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    //button to main menu
    public void MainMenuButton()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
