using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class cMenu : MonoBehaviour {
    public string[] toolbarStrings = new string[] { "Level1", "Level 2" };
    public int toolbarInt = 0;
    public GUIStyle mystyle;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

		
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 150 , Screen.height / 2, 100, 50), "Play")) {
			Application.LoadLevel ("ScGame");
		}

        if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height / 2, 100, 50), "Quit"))
        {
            Application.Quit();
        }
        //GUI.Button (new Rect (Screen.width/2 + 50 , Screen.height/2 , 100, 50), "Play level 2");
    }
}
