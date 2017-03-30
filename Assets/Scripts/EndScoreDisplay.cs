using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class EndScoreDisplay : MonoBehaviour
{
    private Text text;
    private ScoreAbsorber scoreAbsorber;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
        // FIXME doesn't work if set here
//        text.text = "Score: " + scoreAbsorber.Score;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + scoreAbsorber.Score;
    }
}
