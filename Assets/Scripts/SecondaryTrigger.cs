using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour
{
    Collider expectedCollider;
    public int ScorePerHit = 1;
    private ScoreKeeper scoreKeeper;

    void Start()
    {
        // get reference to the ScoreKeeper object
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            scoreKeeper.IncrementScoreBy(ScorePerHit);
        }
    }
}