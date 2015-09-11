using UnityEngine;
using System.Collections;

public class NextScene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("MainScene"); 
		}
	}
}
