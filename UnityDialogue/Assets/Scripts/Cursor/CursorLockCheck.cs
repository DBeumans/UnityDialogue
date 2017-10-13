using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLockCheck : MonoBehaviour {

    [SerializeField]
    private GameObject dialogueUI;

    private bool cursorActive;
    public bool Get_CursorActiveState { get { return cursorActive; } }

    private void Start()
    {
        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
    }

    private void Update()
    {
        if(dialogueUI.activeInHierarchy)
        {
            CursorLockState.ToggleCursorLockState(CursorLockMode.None);
            cursorActive = true;
            return;
        }

        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
        cursorActive = false;

    }
}
