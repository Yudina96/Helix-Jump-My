using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
    [Min(0)]
    public float Volume;
    private AudioListener _audioListener;

    private void Awake()
    {
     AudioListener.volume = Volume;
    }
    void Update()
    {
        
    }
}
