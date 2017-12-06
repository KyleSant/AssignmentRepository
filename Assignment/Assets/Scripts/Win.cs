using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {

    public Text Winner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(GoalNetLvl3.timesHit == GoalNetLvl3.hitWinner)
        {
            Winner.text = "The Winner is: Player1";
        }

        else if (GoalNet2Lvl3.timesHit == GoalNet2Lvl3.hitWinner)
        {
            Winner.text = "The Winner is: Player2";
        }

    }
}
