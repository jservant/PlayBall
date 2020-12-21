using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreKeeper : MonoBehaviour
{
    public static float distance;
    float bestDistance = 0f;
    [SerializeField] Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (distance > bestDistance && distance > 1f)
        {
            score.text = "Best Hit: " + (distance - (distance%0.01f)) + "m";
            bestDistance = distance;
        }
    }
}
