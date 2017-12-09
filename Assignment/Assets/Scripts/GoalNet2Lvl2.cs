using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalNet2Lvl2 : MonoBehaviour
{

    public static int timesHit = 0;
    public Text Score;
    public int maxHits;
    // Use this for initialization
    void Start()
    {
        Score.text = "Player1's Score is: 0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit = timesHit + 2;
        print(timesHit);
        Score.text = "Player1's Score is: " + timesHit;

        if (timesHit >= maxHits)
        {
            SceneManager.LoadScene("Level 03");
        }
    }
}
