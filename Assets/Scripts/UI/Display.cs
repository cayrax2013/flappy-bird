﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Display : MonoBehaviour
{
    [SerializeField] protected CanvasGroup canvasGroup;
    [SerializeField] protected Button button;

    private void OnEnable()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();

    public abstract void Open();

    public abstract void Close();
}
