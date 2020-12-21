using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterUI : MonoBehaviour
{
    public static Text result;
    public static float timer;

    void Start()
    {
        result = GetComponent<Text>();
        result.text = "Get Ready!";
        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (result.text != "")
        {
            timer -= Time.deltaTime;
            if (timer <= 0) { result.text = ""; }
        }
    }
}
