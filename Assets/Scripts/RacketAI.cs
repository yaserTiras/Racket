using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketAI : Racket
{
    public Transform Ball;
    protected override void Movement()
    {
        if (Ball.transform.position.x > 0)
        {
            if (Ball.transform.position.y > transform.position.y)
            {
                Rb.velocity = new Vector2(0, 1) * MoveSpeed * Time.deltaTime;
            }
            else
            {
                Rb.velocity = new Vector2(0, -1) * MoveSpeed * Time.deltaTime;
            }
        }
       
    }
}
