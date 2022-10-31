﻿using System.Collections;
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
    private int index;

    // Esse método vai ser chamado do NPC para poder chamar o diálogo
    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            // Ainda há textos
            if(index < sentences.Length - 1)
            {
                // Pula para a próxima frase
                index++;
                // Limpa o texto
                speechText.text = "";
                // Chama a próxima frase
                StartCoroutine(TypeSentence());
            }
            else // Lido quando acaba os textos
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
            }
        }
    }

    
}
