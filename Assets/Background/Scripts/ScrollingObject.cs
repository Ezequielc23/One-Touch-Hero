﻿/*Created by Classic Cap Studios
Responsible for moving a background sprite downward at a specefied speed. */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D attached to the background.
        rb2d = GetComponent<Rigidbody2D>();

        //Start the object moving.
        rb2d.velocity = new Vector2(0, -1);
    }

    void Update()
    {
       // If the game is over, stop scrolling.
       // if (GameControl.instance.gameOver == true)
       // {
       //     rb2d.velocity = Vector2.zero;
       // }
    }
}