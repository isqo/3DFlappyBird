using UnityEngine;
using System.Collections;

public class cMoveBird : MonoBehaviour {
    public float Speed=5;
    public float Yvelocity = 12.0f;
    public static bool CollisionFlag = false;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (!CollisionFlag)
        {
            if (Input.GetKey("space"))
                GetComponent<Rigidbody>().velocity = new Vector3(0, Yvelocity, 0);

            transform.Translate(0, 0, Time.deltaTime * Speed);
        }
    }


}
