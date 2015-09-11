using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int score; 
	// Use this for initialization
	void Start () {
		score = 0; 
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 200, 50), "You have: " + score.ToString ()+ " out of 100.");
		
	}
	void Update(){

		if (score >= 100) {

			Application.LoadLevel("WinScene"); 
		}
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.CompareTag("car") ){
			score += 10;
			Destroy (other.gameObject); 
			}
		if (other.gameObject.CompareTag("plane") ){
			score += 15;
			Destroy (other.gameObject); 
		}
		if (other.gameObject.CompareTag("ball") ){
			score += 1;
			Destroy (other.gameObject); 
		}
		if (other.gameObject.CompareTag("money") ){
			score += 3;
			Destroy (other.gameObject); 
		}
		if (other.gameObject.CompareTag("item") ){
			score += 2;
			Destroy (other.gameObject); 
		}
		if (other.gameObject.CompareTag("enemy") ){
			score -= 2;
			Destroy (other.gameObject); 
		}
	}
}
