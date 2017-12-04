using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalNet : MonoBehaviour {

    int timesHit;
    public int maxHits;
    // Use this for initialization
    void Start()
    {
        timesHit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);

        if (timesHit >= maxHits)
        {
            SceneManager.LoadScene("Level 02");
        }
    }

}
