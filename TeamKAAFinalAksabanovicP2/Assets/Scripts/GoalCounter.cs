using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCounter : MonoBehaviour
{
    public Scoring score;

    // Update is called once per frame
    void Update()
    {

    }
        void OnTriggerEnter(Collider collision)
        {
            score.AddScore(1);
        }
    
}