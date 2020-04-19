using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeatherHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent _thunder;
    [SerializeField] private float _minDelayBetweenThunder;
    [SerializeField] private float _maxDelayBetweenThunder;

    private float _delayBetweenThunder;
    private float _elapsedTime = 0f;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        _delayBetweenThunder = Random.Range(_minDelayBetweenThunder, _maxDelayBetweenThunder);

        if (_elapsedTime >= _delayBetweenThunder)
        {
            _elapsedTime = 0f;
            _thunder?.Invoke();
        }
    }
}
