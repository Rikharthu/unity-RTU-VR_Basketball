using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public float TimeTillNextLevel = 5.0f;
    public static bool progress=false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (progress)
        {
            TimeTillNextLevel -= Time.deltaTime;
//            print("Time till next level: "+TimeTillNextLevel);
            if (TimeTillNextLevel <= 0)
            {
                // LoadNextScene();
                EndRound();
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            print("FIRE");
        }
    }

    public void EndRound(){
        FindObjectOfType<GameController>().EndRound();
    }

    public void LoadNextScene()
    {
        // Load Scene
        // 1. Get current scene's index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // 2. Load currentSceneIndex + 1
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadPreviousScene()
    {
        // Load Scene
        // 1. Get current scene's index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // 2. Load currentSceneIndex + 1
        SceneManager.LoadScene(currentSceneIndex - 1);
    }
}