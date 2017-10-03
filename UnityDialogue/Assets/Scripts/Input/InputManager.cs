using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private static Vector3 movementInput = new Vector2();

    public static Vector3 Get_MovementInput { get { return movementInput; } }

    private void Update()
    {
        movementInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
    }
}
