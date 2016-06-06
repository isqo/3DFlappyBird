using UnityEngine;
using Assets.Levels;
using Assets.Core.Levels;

public class cMovePipes : MonoBehaviour {
    private bool UpDownFlag = true;
	void Update () {
        if (LevelManager.IsTheCurrentLevel(typeof(Level3)))
        {
            if (UpDownFlag)
            {
                transform.Translate(0, Time.deltaTime * 5, 0);
                if (transform.position.y > 2)
                {
                    UpDownFlag = false;
                }
            }
            else
            {
                transform.Translate(0, -Time.deltaTime * 5, 0);
                if (transform.position.y < -2)
                {
                    UpDownFlag = true;
                }
            }
        }
    }
}
