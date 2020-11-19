using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BatControl : MonoBehaviour
{
    public InputAction mouse;
    public GameObject player;

    void Update()
    {
        Vector2 inputVector = mouse.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        Debug.Log(inputVector);
        finalVector.x = inputVector.x;
        transform.RotateAround(player.transform.position, Vector3.up, 20 * Time.deltaTime);
    }

    private void OnEnable() { mouse.Enable(); }
    private void OnDisable() { mouse.Disable(); }

}
