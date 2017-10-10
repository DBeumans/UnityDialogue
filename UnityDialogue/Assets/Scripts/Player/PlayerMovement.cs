using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private float rotationSpeed;

    private Rigidbody rigid;

    private Vector3 movement;
    private Vector3 rotation;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = InputManager.Get_MovementInput.x;
        float vertical = InputManager.Get_MovementInput.y;
        
        Vector3 movement_vertical = transform.forward * vertical;
        Vector3 rotation_horizontal = transform.up * horizontal;

        movement = movement_vertical;
        rotation = rotation_horizontal;

    }

    private void FixedUpdate()
    {
        rotationCalculation();
        movementCalculation();
    }

    private void movementCalculation()
    {
        movement = movement * movementSpeed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + movement);
    }

    private void rotationCalculation()
    {
        rotation = rotation * rotationSpeed * Time.fixedDeltaTime;
        rigid.MoveRotation(rigid.rotation * Quaternion.Euler(rotation));
        
    }
}
