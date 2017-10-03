using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;

    private Rigidbody rigidbody;

    private Vector3 movement;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = InputManager.Get_MovementInput.x;
        float vertical = InputManager.Get_MovementInput.y;

        movement = new Vector3(horizontal, 0, vertical);

    }

    private void FixedUpdate()
    {
        movement = movement * movementSpeed * Time.fixedDeltaTime;
        rigidbody.MovePosition(rigidbody.position + movement);
    }
}
