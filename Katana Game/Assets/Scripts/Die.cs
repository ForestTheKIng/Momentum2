using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public PlayerMovement pm;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            pm.Respawn();
        }
    }
}
