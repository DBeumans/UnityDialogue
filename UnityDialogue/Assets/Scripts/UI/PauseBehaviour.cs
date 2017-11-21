using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehaviour : MonoBehaviour {

    private ToggleUI toggleUI;
    private PlayerData playerData;

    private bool isPaused;
    public bool Get_IsPaused { get { return isPaused; } }

    private void Start()
    {
        toggleUI = GetComponent<ToggleUI>();
        playerData = FindObjectOfType<PlayerData>();
        
    }

    private void Update()
    {
        if (!InputManager.Get_KeyEscape)
            return;

        if (playerData.IsInConversation)
            return;

        if (toggleUI.Get_PausePanel.activeInHierarchy)
        {
            toggleUI.TogglePauseWindow(false);
            isPaused = false;
            CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
            return;
        }
        toggleUI.TogglePauseWindow(true);
        isPaused = true;
        CursorLockState.ToggleCursorLockState(CursorLockMode.None);
        CursorViewState.SetCursorTexture(CursorViewState.Get_Normal);
    }
}
