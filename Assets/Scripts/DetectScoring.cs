using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour
{
    public int ScorePerHit = 1;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        // get reference to the ScoreKeeper object
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        // call it's method to increase score (because IncrementScore is declared public)
        scoreKeeper.IncrementScoreBy(ScorePerHit);
    }
}