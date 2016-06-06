using UnityEngine;
using System.Timers;
using System.Diagnostics;

public class cCollision : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        cMoveBird.CollisionFlag = true;
    }
}
