using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallServe : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] float ballTimer;
    [SerializeField] float ballSpeed;

    void Start()
    {

    }

    void Update()
    {
        ballTimer += Time.deltaTime;
        if (ballTimer >= 5)
        {
            GameObject newBall = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody ballrb = newBall.GetComponent<Rigidbody>();
            ballrb.AddForce(-transform.forward * ballSpeed);
            ballTimer = 0f;
        }
    }
}
