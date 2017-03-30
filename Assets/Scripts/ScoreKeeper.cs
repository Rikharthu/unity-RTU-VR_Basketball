using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int Score = 0;
    public int Period = 0;

    // Use this for initialization
    void Start()
    {
        // gameObject - Game Object to which this component is attached to
        // prevent destroing ScoreKeeper object
        DontDestroyOnLoad(gameObject);
        // used and destroyed in ScoreAbsorber

        // by default, when changing scenes, all game objects in old scene are destroyed.
        // DontDestroyOnLoad() prevents game objects from being destroyed, thus transferind it to the next scene
    }

    // Update is called once per frame
    void Update()
    {
    }

    // make this method available to other scripts and objects
    public void IncrementScoreBy(int bonus)
    {
        Score+=bonus;
        print("You scored. Your current score is " + Score);

        // play sound
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}