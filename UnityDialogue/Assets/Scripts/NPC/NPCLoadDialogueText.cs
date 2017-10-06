using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;

public class NPCLoadDialogueText : MonoBehaviour {

    public void loadDialogueText(XmlDocument document)
    {
        XmlNodeList totalNPCs = document.GetElementsByTagName("npc");

        for (int i = 0; i < totalNPCs.Count; i++)
        {
            //Debug.Log(totalNPCs[i].Attributes["name"].Value);
        }
    }
}
