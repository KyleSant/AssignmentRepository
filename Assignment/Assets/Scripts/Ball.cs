using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Vector3 ballPos;
    bool gameStarted = false;


    // Use this for initialization
    void Start()
    {

        ballPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
        gameObject.transform.position.z);


    }

    // Update is called once per frame
    void Update() {

        if(gameStarted == false)
        {
           transform.position = ballPos;
        }


        {
           
            if (Input.GetMouseButton(0) && gameStarted == false)
            {
                gameStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 7f);
            }


        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "GoalNet1")
        {
            gameStarted = false;
        }
        if (collision.gameObject.name == "GoalNet2")
        {
            gameStarted = false;
        }
  
    }
}
