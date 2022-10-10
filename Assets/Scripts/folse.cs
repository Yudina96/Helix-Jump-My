using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folse : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
    public AudioSource PlatformBreak;

    private void OnCollisionEnter(Collision collision)
    {
        PlatformBreak.Play();
    }
}
