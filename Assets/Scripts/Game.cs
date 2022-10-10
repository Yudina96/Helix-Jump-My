using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Controls controls;

    public AudioSource BackroundMusic;

    

    

    private void OnCollisionEnter(Collision collision)
    {
        BackroundMusic.Play();
    }

    public enum State
    {
        Playing, Won, Loss,
    }
    public State CurrentState { get; private set; }


    public void OnPlayerDied()
    { 

        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        controls.enabled = false;
        Debug.Log("Game Ovet");
        ReloadLevel();
    }
    
    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        controls.enabled = false;
        LevelIndex++;
        Debug.Log("You won");
        ReloadLevel();
    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
       private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    private const string LevelIndexKey = "LevelIndex";

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
