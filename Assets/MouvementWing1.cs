using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.Timers;
using System;


public class MouvementWing1: MonoBehaviour {
    float z = 30f;
    public Timer timer1;
    public bool flag = false;
    public bool test = false;
    // Use this for initialization
    void Start () {
        timer1 = new Timer();
        timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
        timer1.Interval = 1000; // in miliseconds
        timer1.Start();
    }
	
	// Update is called once per frame
	void Update () {
        if(flag)
        {

            if (test)
            {
                transform.Rotate(new Vector3(0.0f, 0.0f, -z));
                test = false;

            }
            else
            {
                transform.Rotate(new Vector3(0.0f, 0.0f, z));
                test = true;
            
            }
            flag = false;
        }
     
	}

    private void timer1_Tick(object sender, EventArgs e)
    {
        flag = true;
    }
}
