using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameOverScreen : Display
{
    public event UnityAction RestartButtonClick;

    public void OpenMainMenu()
    {
        canvasGroup.alpha = 0;
        button.interactable = false;

        SceneManager.LoadScene("MainMenu");
    }

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
        RestartButtonClick?.Invoke();
    }
}
