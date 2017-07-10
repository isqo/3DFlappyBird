using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets;
using Assets.Levels;

public class cEndGame : MonoBehaviour {

	public static bool flag = false;
    public Text ScoreText;
    public Text WinOrLoseText;

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 35, 100, 30), "Replay")) 
            Application.LoadLevel ("ScLevel");
		if (flag == false) {
            WinOrLoseText.text = "You LOSE !";
        }
        else {
            WinOrLoseText.text = "you WIN !";
        } 

        ScoreText.text = "Score: " + Score.points.ToString();
    }		
}
