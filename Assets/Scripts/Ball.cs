using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [Range(1, 50)]
    public float BallSpeed;
    public Racket LeftRacket, RightRacket;
    
    private Rigidbody2D Rb { get { return GetComponent<Rigidbody2D>(); } }

    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = new Vector2(1, 0) * BallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tagManager=collision.gameObject.GetComponent<TagManager>();
        if (tagManager != null)
        {
            Taggs taggs = tagManager.taggs;
            if (taggs.Equals(Taggs.Left_Wall))
            {
                LeftRacket.AddScore();
                
            }
            else if (taggs.Equals(Taggs.Right_Wall))
            {
                RightRacket.AddScore();
            }

            if (taggs.Equals(Taggs.Left_Player))
            {
                CalculateBallWay(collision, 1);
            }
            else if (taggs.Equals(Taggs.Right_Player))
            {
                CalculateBallWay(collision, -1);
            }
        }
    }

    private void CalculateBallWay(Collision2D Col,int x)
    {
        float a = transform.position.y - Col.transform.position.y;
        float b = Col.collider.bounds.size.y;
        float z = a / b;

        Rb.velocity = new Vector2(x,z)*BallSpeed;
    }
}
