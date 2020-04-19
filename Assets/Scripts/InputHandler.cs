using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent _onTapScreen;

    private void OnMouseDown()
    {
        _onTapScreen?.Invoke();
    }
}
