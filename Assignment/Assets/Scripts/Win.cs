using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    public Text Winner;
    public Text finalScore;


	// Use this for initialization
	void Start () {


        
	}
	
	// Update is called once per frame
	void Update () {

        int total1 = GoalNet.timesHit + GoalNetLvl2.timesHit + GoalNetLvl3.timesHit;
        int total2 = GoalNet2.timesHit + GoalNet2Lvl2.timesHit + GoalNet2Lvl3.timesHit;

        finalScore.text = "The Final Score of Player1 is: " + total1 + "\n" + " " + "The Final Score of Player2 is: " + total2;

        if (total1 > total2)
        {
            Winner.text = "The Winner is: Player1";
        }

        else if(total1 == total2)
        {
            Winner.text = "The Winner: DRAW";
        }

        else 
        {
            Winner.text = "The Winner is: Player2";
        }

        
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
