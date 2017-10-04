using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

    [SerializeField]
    protected string npcName;

    protected GameObject player;

    protected void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    protected void Update()
    {
        if(CheckRange.CheckRangeBetweenObjects(this.gameObject.transform, player.gameObject.transform, 3))
        {
            
        }
    }
}
