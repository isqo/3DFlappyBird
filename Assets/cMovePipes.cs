using UnityEngine;
using System.Collections;
using Assets.Levels.Level3;

public class cMovePipes : MonoBehaviour {

    private bool flag = true;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if(level3.isActif && !cMoveBird.CollisionFlag)
        {
            if (flag)
            {
                transform.Translate(0, Time.deltaTime * 5, 0);
                if (transform.position.y > 2)
                {
                    flag = false;
                }
            }
            else
            {
                transform.Translate(0, -Time.deltaTime * 5, 0);
                if (transform.position.y < -2)
                {
                    flag = true;
                }
            }
        }
    }
}
