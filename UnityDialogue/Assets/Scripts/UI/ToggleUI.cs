using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour {

    [SerializeField]
    private Text interactionText;

    [SerializeField]
    private GameObject dialogueWindow;

    [SerializeField]
    private GameObject pausePanel;
    public GameObject Get_PausePanel { get { return pausePanel; } }

    public void ToggleInteractionText(string text)
    {
        interactionText.text = text;
    }

    public void ToggleDialogueWindow(bool value)
    {
        dialogueWindow.SetActive(value);
    }

    public void TogglePauseWindow(bool value)
    {
        pausePanel.SetActive(value);
    }
}
