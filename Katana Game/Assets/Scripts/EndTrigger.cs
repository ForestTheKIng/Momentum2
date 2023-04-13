using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTrigger : MonoBehaviour
{
    [Header("Player")] 
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().Respawn();
    }
}
