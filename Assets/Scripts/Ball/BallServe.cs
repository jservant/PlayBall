using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallServe : MonoBehaviour
{
    public GameObject ball;
    public GameObject spawn;
    [SerializeField] float ballTime;
    [SerializeField] int ballTimer = 8;
    [SerializeField] int ballSpeed;
    [SerializeField] Animator cannonAnim;

    void Update()
    {
        if (ballTime < ballTimer) { ballTime += Time.deltaTime; } // Time to launch ball still goes up
        else
        {
            cannonAnim.SetTrigger("playShoot");
            GameObject newBall = Instantiate(ball, spawn.transform.position, transform.rotation); // Spawn new instance of ball
            Rigidbody ballrb = newBall.GetComponent<Rigidbody>(); // That specific ball gets a rb
            ballSpeed = Random.Range(1000, 1800); // Randomize speed on the ball
            ballrb.AddForce(-transform.forward * ballSpeed); // shuut
            ballTimer = Random.Range(5, 10);
            ballTime = 0f; // Reset the time that needs to go up
        }
    }
}
