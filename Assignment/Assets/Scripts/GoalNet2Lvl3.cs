using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalNet2Lvl3 : MonoBehaviour {

    public static int timesHit = 0;
    public Text Score;
    public int maxHits;
    public static int hitWinner;

    // Use this for initialization
    void Start()
    {
        hitWinner = maxHits;
        Score.text = "Player1's Score is: 0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(timesHit);
        Score.text = "Player1's Score is: " + timesHit;

        if (timesHit >= maxHits)
        {
            SceneManager.LoadScene("Win");
        }
    }

}
