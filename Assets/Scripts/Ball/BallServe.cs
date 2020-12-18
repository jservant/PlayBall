﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallServe : MonoBehaviour
{
    public GameObject ball;
    public GameObject spawn;
    [SerializeField] float ballTime;
    [SerializeField] int ballTimer = 8;
    [SerializeField] int ballSpeed;

    void Update()
    {
        if (ballTime < ballTimer) { ballTime += Time.deltaTime; } // Time to launch ball still goes up
        else
        {
            GameObject newBall = Instantiate(ball, spawn.transform.position, transform.rotation); // Spawn new instance of ball
            Rigidbody ballrb = newBall.GetComponent<Rigidbody>(); // That specific ball gets a rb
            ballSpeed = Random.Range(500, 1000); // Randomize speed on the ball
            ballrb.AddForce(-transform.forward * ballSpeed); // shuut
            ballTimer = Random.Range(6, 15);
            ballTime = 0f; // Reset the time that needs to go up
        }
    }
}