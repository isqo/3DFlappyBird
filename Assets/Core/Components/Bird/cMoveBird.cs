using UnityEngine;
using System.Collections;
using Assets.Levels;
using System.Diagnostics;
using Assets.Core.Levels;

public class cMoveBird : MonoBehaviour {
    private float Yvelocity = 12.0f;
    private static bool begin = false;
    public static float Speed;
    public static bool CollisionFlag = false;
    public AudioClip son;

    public static Stopwatch stopwatch; // From System.Timers

    // Use this for initialization
    void Start () {
        Speed = 5;
        stopwatch = new Stopwatch();
    }

    public static void Reset()
    {
        begin = false;
        CollisionFlag = false;
    }

	// Update is called once per frame
	void Update () {
        if(!CollisionFlag)
        {
            if(begin)
            {

                if (Input.GetKey("space"))
                {
                    GetComponent<Rigidbody>().velocity = new Vector3(0, Yvelocity, 0);
                    GetComponent<AudioSource>().PlayOneShot(son);
                }
                
                transform.Translate(0, 0, Time.deltaTime * Speed);
            }
            else
            {
                if (Input.GetKey("space"))
                {
                    begin = true;
                    LevelManager.Start();
                }
            }
        }
        else
        {
            if(!stopwatch.IsRunning)
                stopwatch.Start();
            else if (stopwatch.ElapsedMilliseconds > 1500)
                Application.LoadLevel("ScEndGame");
            
        }
    }
}
