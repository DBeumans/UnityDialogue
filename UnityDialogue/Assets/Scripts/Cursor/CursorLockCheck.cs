using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLockCheck : MonoBehaviour {

    private bool cursorActive;
    public bool Get_CursorActiveState { get { return cursorActive; } }

    [SerializeField]
    private List<GameObject> canvasObjects = new List<GameObject>();
 
    private PlayerData playerData;

    private void Start()
    {
        playerData = FindObjectOfType<PlayerData>();
        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
    }

    private void Update()
    {
        checkDialoguePanel();
        if (CursorLockState.GetCursorLockState() == CursorLockMode.Locked)
        {
            cursorActive = false;
            return;
        }
        else
        {
            cursorActive = true;
            return;
        }
    }

    private void checkDialoguePanel()
    {
        for (int i = 0; i < canvasObjects.Count; i++)
        {
            if (canvasObjects[i].activeInHierarchy)
            {
                CursorLockState.ToggleCursorLockState(CursorLockMode.None);         
                return;
            }

            
        }
        CursorLockState.ToggleCursorLockState(CursorLockMode.Locked);
        playerData.IsInConversation = false;

    }
}
