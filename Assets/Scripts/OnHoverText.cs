using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class OnHoverText : MonoBehaviour
{
    public TextMeshProUGUI messageText;

    public static Action<string, Vector2> OnMouseHover;
    public static Action OnMouseLouseFocus;

    private void OnEnable()
    {
        OnMouseHover += ShowMessage;
        OnMouseLouseFocus += HideMessage;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowMessage;
        OnMouseLouseFocus -= HideMessage;
    }

    void Start()
    {
        messageText.gameObject.SetActive(false);
    }

    private void ShowMessage(string message, Vector2 mousePos)
    {
        messageText.text = message;
        messageText.gameObject.SetActive(true);

    }

    private void HideMessage()
    {
        messageText.gameObject.SetActive(false);
    }

}
