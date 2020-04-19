using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    [SerializeField] private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private BirdMover _mover;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
        ScoreChanged?.Invoke(_score);
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);

        var highScore = PlayerPrefs.GetInt("highScore");

        if (_score > highScore)
            PlayerPrefs.SetInt("highScore", _score);
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetBird();
    }

    public void Die()
    {
        GameOver?.Invoke();
        Time.timeScale = 0;
    }
}
