using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Display
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        canvasGroup.alpha = 0;
        button.interactable = false;
    }

    public override void Open()
    {
        canvasGroup.alpha = 1;
        button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }
}
