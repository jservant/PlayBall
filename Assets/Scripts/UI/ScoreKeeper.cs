using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HighScoreKeeper.distance < 0) { score.text = "Last Hit: Foul"; }
        else { score.text = "Last Hit: " + (HighScoreKeeper.distance - (HighScoreKeeper.distance % 0.01f)) + "m"; }
    }
}
