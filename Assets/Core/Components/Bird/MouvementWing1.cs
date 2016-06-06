using UnityEngine;
using System.Diagnostics;

public class MouvementWing1 : MonoBehaviour
{

    public const float z = 40f;
    public Stopwatch timer;
    public bool UpDownFlag = false;
    public int delay;

    void Start()
    {
        timer = new Stopwatch();
        delay = 500;
    }

    void Update()
    {
        if (!cMoveBird.CollisionFlag)
        {

            if (Input.GetKey("space") || timer.ElapsedMilliseconds < delay && timer.ElapsedMilliseconds > 0)
            {

                if (!timer.IsRunning)
                    timer.Start();

                if (UpDownFlag)
                {
                    transform.Rotate(new Vector3(0.0f, 0.0f, z));
                    UpDownFlag = false;
                }
                else
                {
                    transform.Rotate(new Vector3(0.0f, 0.0f, -z));
                    UpDownFlag = true;
                }
            }
            else if (timer.ElapsedMilliseconds > delay)
            {
                timer.Reset();
                timer.Stop();
            }
        }
    }
}

