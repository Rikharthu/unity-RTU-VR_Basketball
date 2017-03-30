using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject MenuCanvas;
    public GameObject HUDCanvas;
	public GameObject InterractorStart;
	public GameObject InterractorExit;
	public float roundLength=60;

	private LevelManager levelManager;
	private ScoreKeeper scoreKeeper;

	void Start(){
		levelManager=FindObjectOfType<LevelManager>();
		scoreKeeper=FindObjectOfType<ScoreKeeper>();
	}

	public void StartRound(){
		print("Start round");
		// configure ui
		// MenuCanvas.SetActive(false);
        // HUDCanvas.SetActive(true);
		InterractorStart.SetActive(false);
		InterractorExit.SetActive(false);

		// clear the hall
		GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
		for(int i =0; i<balls.Length;i++){
			Destroy(balls[i]);
		}


		// reset data
		levelManager.TimeTillNextLevel=roundLength;
		scoreKeeper.Score=0;
		scoreKeeper.Period++;

		LevelManager.progress=true;
		BallLauncher.enabled=true;
	}

	public void EndRound(){
        // MenuCanvas.SetActive(true);
		// FIXME do not disable until controller bug is fixed
        // HUDCanvas.SetActive(false);
		print("End round");
		LevelManager.progress=false;
		// BallLauncher.enabled=false;
		InterractorStart.SetActive(true);
		InterractorExit.SetActive(true);
	}

	public void ExitGame(){
		Application.Quit(); 
	}
}
