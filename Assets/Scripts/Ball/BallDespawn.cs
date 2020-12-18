using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallDespawn : MonoBehaviour
{
    float timer;
    float noHitTimer;
    public bool hit = false;

    private void Start()
    {

    }

    void Update()
    {
        if (hit) { timer += Time.deltaTime; noHitTimer = 0f; }
        noHitTimer += Time.deltaTime;
        if (timer >= 4 || noHitTimer >= 4)
        {
            Debug.Log(transform.position.z);
            HighScoreKeeper.distance = transform.position.z;
            if (transform.position.y <= -5) { Debug.Log("OUT OF THE PARK"); Destroy(gameObject); }
            else if (!hit && transform.position.z <= -3.5f) { Debug.Log("Strike"); Destroy(gameObject); }
            else if (transform.position.z <= 1f) { Debug.Log("Foul"); Destroy(gameObject); }
            else if (transform.position.z <= 15f) { Debug.Log("Single"); Destroy(gameObject); }
            else if (transform.position.z <= 30f) { Debug.Log("Double"); Destroy(gameObject); }
            else if (transform.position.z <= 50f) { Debug.Log("Triple"); Destroy(gameObject); }
            else if (transform.position.z > 50f) { Debug.Log("Home Run!"); Destroy(gameObject); }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { hit = true; Debug.Log("PLAYER HAPPENED"); }
    }
}
