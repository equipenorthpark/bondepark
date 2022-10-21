﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    // public LayerMask nos permite referenciar uma layer que a gente tenha criado
    public LayerMask playerLayer;
    public float radious;

    private DialogueControl dc;

    private void Star()
    {
        // Quando vc inicializa o jogo o FindObjectOfType vai procurar na cena algum objeto que tenho o DialogueControl anexado
        dc = FindObjectOfType<DialogueControl>();
    }

    public void FixedUpdate()
    {
        Interact();
    }

    // Vai ser a interação do NPC com o player
    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if(hit != null)
        {
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Vai desenhar uma esfera na janela da cena e vai passar como parametro a posição do objeto e o raio que é o mesmo da esfera de colisção dalí de cima
        Gizmos.DrawWireSphere(transform.position, radious);
    }

}
