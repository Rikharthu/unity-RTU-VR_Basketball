using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour {

	public float TimeTilDestroy=5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collider)
    {	
		// print("OnTriggerEnter");
        // Destroy(collider.gameObject);

    }

	// private void destroyObject(GameObject obj){
	// 	System.Threading.Thread.Sleep((int)TimeTilDestroy*1000);
	// 	Destroy(obj);
	// }
}
