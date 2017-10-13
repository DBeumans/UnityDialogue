using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLockState : MonoBehaviour {

    public static void ToggleCursorLockState(CursorLockMode lockmode)
    {
        Cursor.lockState = lockmode;

    }

    public static CursorLockMode GetCursorLockState()
    {
        CursorLockMode mode;
        mode = Cursor.lockState;
        return mode;
    }
}
