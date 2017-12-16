using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {
    float y = 0f;

	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
            y += 0.10f;
          Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, y,
                                            gameObject.transform.position.z);
           gameObject.transform.position = newPaddlePos;
        }

        if (Input.GetKey("down"))
        {
            y -= 0.10f;
            Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, y,
                                            gameObject.transform.position.z);
            gameObject.transform.position = newPaddlePos;
        }

         y = Mathf.Clamp(gameObject.transform.position.y, -3.95f, 3.95f);
	}
}
