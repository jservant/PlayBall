using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BatControl : MonoBehaviour
{
    public InputAction mouse;
    public GameObject player;
    [SerializeField] float speedMult;

    void Update()
    {
        Vector2 inputVector = mouse.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.y = inputVector.x;
        //Debug.Log(finalVector);
        transform.RotateAround(player.transform.position, finalVector, speedMult);
    }

    private void OnEnable() { mouse.Enable(); }
    private void OnDisable() { mouse.Disable(); }

}
