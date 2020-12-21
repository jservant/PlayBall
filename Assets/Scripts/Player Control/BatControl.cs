using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BatControl : MonoBehaviour
{
    public InputAction mouse;
    public GameObject player;
    public Collider hitbox;
    public float speedMult = 1;
    //[SerializeField] float speedLimit;

    void Update()
    {
        Vector2 inputVector = mouse.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.y = inputVector.x;
        //Debug.Log(finalVector);
        transform.RotateAround(player.transform.position, finalVector, Mathf.Abs(finalVector.y) * speedMult) ;
        if (inputVector.x == 0) { hitbox.enabled = false; } else { hitbox.enabled = true; }

        var kb = Keyboard.current;
        if (kb.leftBracketKey.wasPressedThisFrame && speedMult > 0.1f) { speedMult -= 0.1f; }
        if (kb.rightBracketKey.wasPressedThisFrame && speedMult < 2.5f) { speedMult += 0.1f; }
    }

    private void OnEnable() { mouse.Enable(); }
    private void OnDisable() { mouse.Disable(); }

}
