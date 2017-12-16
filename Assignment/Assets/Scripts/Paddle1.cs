using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 16) - 8;
  

        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x,mousePosInUnits,
                                            gameObject.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -4.03f, 4.03f);

        gameObject.transform.position = newPaddlePos;

    }
}
