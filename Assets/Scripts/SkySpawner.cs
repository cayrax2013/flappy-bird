using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _skyPrefab;
    [SerializeField] private float _delayBetweenSpawn = 0.5f;
    [SerializeField] private float _minYPos = -1.5f;
    [SerializeField] private float _maxYPos = 4.5f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            var waitForSeconds = new WaitForSeconds(_delayBetweenSpawn);

            var randomPostionSpawn = Random.Range(_minYPos, _maxYPos);

            Instantiate(_skyPrefab, new Vector2(transform.position.x, randomPostionSpawn), Quaternion.identity);

            yield return waitForSeconds;
        }
    }
}
