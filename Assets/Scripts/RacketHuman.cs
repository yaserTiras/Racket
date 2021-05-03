using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketHuman : Racket
{

    protected override void Movement()
    {
        float moveAxis = Input.GetAxis("Vertical1");
        Rb.velocity = new Vector2(0, moveAxis) * MoveSpeed * Time.deltaTime;
    }

}
