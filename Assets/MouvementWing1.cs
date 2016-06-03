using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.Timers;
using System;

public class MouvementWing1 : MonoBehaviour
{

    float z = 40f;
    public Stopwatch timer1;
    public bool test = false;
    public int delay;
    // Use this for initialization
    void Start()
    {
        timer1 = new Stopwatch();
        delay = 500;
    }

    // Update is called once per frame
    void Update()
    {

        if (!cMoveBird.CollisionFlag && Input.GetKey("space") || timer1.ElapsedMilliseconds < delay && timer1.ElapsedMilliseconds > 0)
        {

            if (!timer1.IsRunning)
                timer1.Start();

            if (test)
            {
                transform.Rotate(new Vector3(0.0f, 0.0f, z));
                test = false;
            }
            else
            {
                transform.Rotate(new Vector3(0.0f, 0.0f, -z));
                test = true;
            }
        }

        if (timer1.ElapsedMilliseconds > delay)
        {
            timer1.Reset();
            timer1.Stop();
        }
    }
}

