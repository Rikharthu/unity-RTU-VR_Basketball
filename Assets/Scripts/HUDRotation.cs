using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDRotation : MonoBehaviour {

	public bool RotateVertically=true;

	private Camera camera;


	void Start () {
		camera = transform.parent.GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lookVector = camera.transform.forward;
        Debug.DrawRay(transform.position, lookVector, Color.cyan);
	    
		if(!RotateVertically){
			lookVector = Vector3.ProjectOnPlane(lookVector, Vector3.up);
        	Debug.DrawRay(transform.position, lookVector, Color.red);
		}
	    transform.localRotation = Quaternion.LookRotation(lookVector);
	}
}
