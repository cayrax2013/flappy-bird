using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _lightningSound;
    [SerializeField] private AudioSource _passedTheZoneSound;
    [SerializeField] private AudioSource[] _backGroundMusic;

    private void Start()
    {
        EnableBackgroundMusic();
    }

    public void CallSoundLightninh()
    {
        _lightningSound.Play();
    }

    public void EnableSoundPassedTheZone()
    {
        _passedTheZoneSound.Play();
    }

    private void EnableBackgroundMusic()
    {
        var randomMusic = Random.Range(0, _backGroundMusic.Length);

        _backGroundMusic[randomMusic].Play();
    }
}
