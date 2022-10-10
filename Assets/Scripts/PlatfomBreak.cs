using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfomBreak : MonoBehaviour
{
    public AudioSource PlatformBreak;

    private void OnCollisionEnter(Collision collision)
    {
        PlatformBreak.Play();
    }
}
