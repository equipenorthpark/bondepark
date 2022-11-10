using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinas : MonoBehaviour
{

    [SerializeField] private float tiempoEntreDaño;

    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<Combatejugador>().TomarDaño(25);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
}
