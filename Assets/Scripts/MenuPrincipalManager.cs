using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDoJogo;

    public void Jogar()
    {
        SceneManager.LoadScene("Mapa");
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
    
}
