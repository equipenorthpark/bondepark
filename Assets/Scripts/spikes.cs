﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.CompareTag("Player")){
            Debug.Log("jugador Entro");
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.collider.CompareTag("Player")){
            Debug.Log("Jugador Salio");
        }
    }
}