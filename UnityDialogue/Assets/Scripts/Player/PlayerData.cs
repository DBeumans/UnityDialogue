using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    private bool isInConversation;
    public bool IsInConversation
    {
        get { return isInConversation; }
        set { isInConversation = value; }
    }

    private void Start()
    {
        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
    }
}
