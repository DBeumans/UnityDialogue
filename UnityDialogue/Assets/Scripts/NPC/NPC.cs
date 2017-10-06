using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC : MonoBehaviour {

    [SerializeField]
    protected string npcName;

    protected GameObject player;

    protected ToggleUI ui;

    protected bool isInConversation;

    protected NPCLoadDialogueText NPCDialogueTextLoader;

    protected void Start()
    {
        NPCDialogueTextLoader = GetComponent<NPCLoadDialogueText>();

        player = GameObject.FindGameObjectWithTag("Player");

        ui = GameObject.FindObjectOfType<ToggleUI>();

        NPCDialogueTextLoader.loadDialogueText(LoadXML.LoadLocalFile("XML/npc_dialogue"));
    }

    protected void Update()
    {
        if(!CheckRange.CheckRangeBetweenObjects(this.gameObject.transform, player.gameObject.transform, 3))
        {
            ui.ToggleInteractionText("");
            ui.ToggleDialogueWindow(false);
            isInConversation = false;
            return;
        }
        if (isInConversation)
            return;
        ui.ToggleInteractionText("Press E to chat");
        CheckPlayerInput();
    }

    protected void CheckPlayerInput()
    {
        if (!InputManager.Get_KeyE)
            return;

        isInConversation = true;

        ui.ToggleInteractionText("");
        ui.ToggleDialogueWindow(true);
    }   
}
