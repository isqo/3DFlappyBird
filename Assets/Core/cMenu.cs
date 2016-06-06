using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class cMenu : MonoBehaviour {
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2, 100, 30), "Play")) {
			Application.LoadLevel ("ScLevel");
		}
    }
}
