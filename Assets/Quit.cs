using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{
    private void Update()
    {
        var kb = Keyboard.current;
        if (kb.escapeKey.isPressed) { Application.Quit(); }
    }
}
