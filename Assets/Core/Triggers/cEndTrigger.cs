using UnityEngine;
using System.Collections;

public class cEndTrigger : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        cEndGame.flag = true;
        Application.LoadLevel("ScEndGame");
    }
}
