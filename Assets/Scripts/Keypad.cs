using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour {
    public GameObject KeypadManager;
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    [SerializeField] private Animator Door2;

    private string Answer = "123";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        Ans.text.ToString();

        if (Ans.text == Answer) 
        {
            Ans.text = "CORRECT";
            Door.SetBool("Open", true);
            Door2.SetBool("Open", true);
            GameObject.Find("Door").layer = 0;
            GameObject.Find("Door2").layer = 0;
            KeypadManager.SetActive(false);
            Time.timeScale = 1f;
            GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Ans.text = "INCORRECT";
        }
    }
}
