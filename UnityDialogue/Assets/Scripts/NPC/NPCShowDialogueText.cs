using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NPCShowDialogueText : MonoBehaviour {

    [SerializeField]
    private Text dialogueText;

    private NPCLoadDialogueText npcDialogueText;
    private NPCSetButton NPCButton;

    private ToggleUI ui;

    private void Start()
    {
        npcDialogueText = GetComponent<NPCLoadDialogueText>();
        NPCButton = GetComponent<NPCSetButton>();

        ui = FindObjectOfType<ToggleUI>();

        dialogueText.text = "";
    }
    
    public void showMessage(int index)
    {
        NPCButton.disableButtons();
        dialogueText.text = npcDialogueText.Get_Messages[index].Get_Message;

        var optionsList = npcDialogueText.Get_Messages[index].Get_Options;

        for (int i = 0; i < optionsList.Count; i++)
        {
            var count = i;
            var response = optionsList[count].Response;
            Button optionButton = NPCButton.SetButtonText(optionsList[i].Option);

            if (response < 0)
                optionButton.onClick.AddListener(delegate () { closeConversation(); });
                
            else
                optionButton.onClick.AddListener(delegate () { this.showMessage(response); });                
     
        }
        ui.ToggleDialogueWindow(true);
        
    }

    private void closeConversation()
    {
        ui.ToggleDialogueWindow(false);
    }
}
