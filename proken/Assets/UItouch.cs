using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UItouch : MonoBehaviour {

    public GameObject box;
    public float speed = 3.0f;

    float roll = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;


        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, roll, 0), step);
    }

    public void touch()
    {
        roll += 90;
    }
}
