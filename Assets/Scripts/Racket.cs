using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum PlayerControlSide
{
    Left, Right
};

public abstract class Racket : MonoBehaviour
{
    public int Score { get; private set; }
    public TMP_Text ScoreText;
    public float MoveSpeed;
    public PlayerControlSide playerControlSide;

    public Rigidbody2D Rb { get { return GetComponent<Rigidbody2D>();  } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    protected abstract void Movement();

    public void AddScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
