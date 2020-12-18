using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction wasd;
    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // player movement
        Vector2 inputVector = wasd.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.x = inputVector.x; finalVector.z = inputVector.y;
        controller.Move(finalVector * Time.deltaTime * 3.14f);

        //if (transform.position.y >= 0.5) { transform.position.y = new Vector3(transform.position.x, 0.5f, transform.position.z); }
    }

    private void OnEnable() { wasd.Enable(); }
    private void OnDisable() { wasd.Disable(); }
}
