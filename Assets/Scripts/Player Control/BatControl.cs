using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BatControl : MonoBehaviour
{
    public InputAction mouse;
    public GameObject player;
    public Collider hitbox;
    //[SerializeField] float speedLimit;

    void Update()
    {
        Vector2 inputVector = mouse.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.y = inputVector.x;
        //Debug.Log(finalVector);
        transform.RotateAround(player.transform.position, finalVector, Mathf.Abs(finalVector.y));
        if (inputVector.x == 0) { hitbox.enabled = false; } else { hitbox.enabled = true; }
        //if (transform.eulerAngles.y > 150) { transform.eulerAngles = new Vector3(transform.eulerAngles.x, 150, transform.eulerAngles.z); }
        //if (transform.eulerAngles.y < -150) { transform.eulerAngles = new Vector3(transform.eulerAngles.x, -150, transform.eulerAngles.z); }
    }

    private void OnEnable() { mouse.Enable(); }
    private void OnDisable() { mouse.Disable(); }

}
