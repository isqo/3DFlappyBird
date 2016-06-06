using UnityEngine;
using Assets.Levels;
using Assets.Core.Levels;

public class cLevel : MonoBehaviour {
	void OnGUI() {
		if (GUI.Button (new Rect (Screen.width / 2 - 200 , Screen.height / 2, 100, 30), "Level 1")) {
            LevelManager.Initialize(new Level1());
			Application.LoadLevel ("ScGame");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 50  , Screen.height / 2, 100, 30), "Level 2")) {
            LevelManager.Initialize(new Level2());
            Application.LoadLevel ("ScGame");
		}
		if (GUI.Button (new Rect (Screen.width / 2 + 100 , Screen.height / 2, 100, 30), "Level 3")) {
            LevelManager.Initialize(new Level3());
            Application.LoadLevel ("ScGame");
		}
	}
}
