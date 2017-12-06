using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlle3 : MonoBehaviour {


    public int speed;
    private Vector3 startPosition;

    // Use this for initialization
    void Start () {

        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
         transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * speed), transform.position.z);

    }
}
