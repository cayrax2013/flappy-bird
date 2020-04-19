using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Bird))]
public class BirdCollisionHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent _passedTheZone;

    private Bird _bird;

    private void Start()
    {
        _bird = GetComponent<Bird>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
        {
            _bird.IncreaseScore();
            _passedTheZone?.Invoke();
        }
        else if (collision.TryGetComponent(out InputHandler inputHandler)) ;
        else
            _bird.Die();
    }
}
