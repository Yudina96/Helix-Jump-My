using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public AudioClip AudioClip;
    [Min(0)]
    public float Volume;

    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        
        _audio.PlayOneShot(AudioClip, Volume);

    }
    private void OnDisable()
    {
        _audio.Stop();
    }
}
