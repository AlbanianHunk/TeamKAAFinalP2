using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    private bool movingRight;
    public float speed = 2.0f;
    void Start()
    {
        movingRight = true;
    }
    void Update()
    {
        if (movingRight == true)
        {
            // move Right
            if (transform.position.x <= -4) movingRight = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
