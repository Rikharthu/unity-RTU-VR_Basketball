using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    private Text text;
    private LevelManager levelManager;


    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // text.text = "time left: " + String.Format("{0:#,0.0}", levelManager.TimeTillNextLevel);
        text.text = String.Format("{0:#,0.0}", levelManager.TimeTillNextLevel);
    }
}
