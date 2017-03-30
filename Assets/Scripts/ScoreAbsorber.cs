using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour
{
    public int Score;

    // Use this for initialization
    void Start()
    {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        Score = oldKeeper.Score;
        print("Scored: " + Score);
        // destroy old game object to prevent it from multiplication (clean/trash)
        Destroy(oldKeeper.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }
}