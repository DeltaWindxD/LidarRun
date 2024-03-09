using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour {
    public GameObject KeypadManager;

    public GameObject EscapeTip;
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    [SerializeField] private Animator Door2;

    private const string ANSWER = "1471";

    //checks if escaped is pressed
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            KeypadManager.SetActive(false);
            Ans.text = "";
        }
    }

    //adds the number pressed to the Ans text
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }


    //Checks if player typed teh right answer
    public void Execute()
    {
        Ans.text.ToString();

        if (Ans.text == ANSWER) 
        {
            Ans.text = "CORRECT";
            GameObject.Find("Door").layer = 0;
            GameObject.Find("Door2").layer = 0;
            Door.SetBool("Open", true);
            Door2.SetBool("Open", true);
            StartCoroutine("StopDoor");
            KeypadManager.SetActive(false);
            Time.timeScale = 1f;
            GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Ans.text = "";
            EscapeTip.SetActive(true);
        }
        else
        {
            Ans.text = "Incorrect";
        }
    }


    //stops the animation of the door
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.3f);
        Door.SetBool("Open", false);
        Door2.SetBool("Open", false);
        Door.enabled = false;
        Door2.enabled = false;
    }


    //clears the text from the screen
    public void Clear()
    {
        Ans.text = "";
    }


    //exits the keypad
    public void Exit()
    {
        KeypadManager.SetActive(false);
        Time.timeScale = 1f;
        GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Ans.text = "";
    }
}
