using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLockCheck : MonoBehaviour {

    private bool cursorActive;
    public bool Get_CursorActiveState { get { return cursorActive; } }

    private void Start()
    {
        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
    }

    private void Update()
    {
        if (CursorLockState.GetCursorLockState() == CursorLockMode.Locked)
        {
            CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
            cursorActive = false;
            return;
        }
        else
        {
            CursorLockState.ToggleCursorLockState(CursorLockMode.None);
            cursorActive = true;
            return;
        }
    }
}
