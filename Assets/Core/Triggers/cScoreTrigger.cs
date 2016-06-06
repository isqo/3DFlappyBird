using UnityEngine;
using System.Collections;
using Assets;
using System.Threading;
using System.Diagnostics;

public class cScoreTrigger : MonoBehaviour {

    // it allows us to catch the triggered event only one time and then we increase the score only once.
    public string PreviousParentGameObject = "";
    void OnTriggerEnter(Collider other)
    {
        string parent = gameObject.transform.parent.name;
        if (!PreviousParentGameObject.Equals(parent))
        {
            Score.points = Score.points + 2;
            PreviousParentGameObject = parent;
        }
    }

}
