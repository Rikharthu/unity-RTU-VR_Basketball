using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureRepeater : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Material>().GetTexture("Bricks").wrapMode=TextureWrapMode.Repeat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
