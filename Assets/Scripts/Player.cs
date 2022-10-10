
using Assets.Scripts;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsGood = true;
    public Material GoodMaterial;
    public Material BadMaterial;

    public float BounceSpeed; 
    public Rigidbody Rigidbody;
    public Game Game;

    public Platform CurrentPlatform;

    public AudioSource bounceAudio;
    public GameObject effect;
    

   

    private void OnCollisionEnter(Collision collision)
    {
        bounceAudio.Play();
    }

    public void Bounce() 
    {
        Instantiate(effect,transform.position,Quaternion.identity);
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {

        
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    





}