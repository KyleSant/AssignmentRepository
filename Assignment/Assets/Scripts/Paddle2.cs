using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
          Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.10f,
                                            gameObject.transform.position.z);
            gameObject.transform.position = newPaddlePos;
        }

        if (Input.GetKey("down"))
        {
            Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.10f,
                                            gameObject.transform.position.z);
            gameObject.transform.position = newPaddlePos;
        }
	}
}
