using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlle3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 paddlePos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
        gameObject.transform.position = paddlePos;

        paddlePos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
        gameObject.transform.position = paddlePos;
    }
}
