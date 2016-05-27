using UnityEngine;
using System.Collections;

public class cMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2, 100, 50), "Play")) {
			Application.LoadLevel ("ScGame");
		}
		GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2 + 70, 100, 50), "Scores");

	}
}
