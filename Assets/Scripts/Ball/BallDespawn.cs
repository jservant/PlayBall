using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallDespawn : MonoBehaviour
{
    float timer;
    float noHitTimer;
    public bool hit = false;

    void Update()
    {
        if (hit) { timer += Time.deltaTime; noHitTimer = 0f; }
        noHitTimer += Time.deltaTime;
        if (timer >= 4 || noHitTimer >= 4)
        {
            Debug.Log(transform.position.z);
            HighScoreKeeper.distance = transform.position.z;
            if (transform.position.y <= -5) { Debug.Log("OUT OF THE PARK"); Destroy(gameObject); }
            else if (!hit && transform.position.z <= -3.5f) { Despawn("Strike"); }
            else if (transform.position.z <= 1f) { Despawn("Foul"); }
            else if (transform.position.z <= 15f) { Despawn("Single"); }
            else if (transform.position.z <= 30f) { Despawn("Double"); }
            else if (transform.position.z <= 45f) { Despawn("Triple"); }
            else if (transform.position.z > 50f) { Despawn("Home Run!"); }
        }
    }

    void Despawn(string Result)
    {
        CenterUI.result.text = Result;
        CenterUI.timer = 1f;
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { hit = true; Debug.Log("PLAYER HAPPENED"); }
    }
}
