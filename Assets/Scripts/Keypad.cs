using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour {
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    [SerializeField] private Animator Door2;

    private string Answer = "123";

    public void Number(int number)
    {
        Ans.text += number.ToString();
        Debug.Log(Ans.text);
    }

    public void Execute()
    {
        Ans.text.ToString();
        Answer.ToString();

        if(Ans.text == Answer) 
        {
            Ans.text = "CORRECT";
            Door.SetBool("Open", true);
            Door2.SetBool("Open", true);
        }
        else
        {
            Debug.Log(Ans.text);
            Ans.text = "INCORRECT";
        }
    }
}
