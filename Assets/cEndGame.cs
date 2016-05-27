using UnityEngine;
using System.Collections;

public class cEndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2, 100, 50), "Replay")) {
			Application.LoadLevel ("ScGame");
		}
		GUI.Label (new Rect (Screen.width/2 - 25, Screen.height/2 + 80, 100, 50), "Scores");
		GUI.Label (new Rect (Screen.width/2 - 25, Screen.height/2 + 120, 100, 50), "123369");
	}
		
}
