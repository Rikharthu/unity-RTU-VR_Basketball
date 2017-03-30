using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PeriodDisplay : MonoBehaviour {

	private Text text;
    private ScoreKeeper scoreKeeper;

	void Start () {
		text = GetComponent<Text>();
	    scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text=scoreKeeper.Period+"";
	}
}
