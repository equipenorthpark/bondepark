using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    // O dialogueObl é a janela de diálogo
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    // O typingSpeed vai servir para adicionar velocidade ao texto que vai aparecer
    public float typingSpeed;
    private string[] sentences;

    // Esse método vai ser chamado do NPC para poder chamar o diálogo
    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;
    }

    
}
