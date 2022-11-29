using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComoJogarManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDoJogo;

    public void Voltar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ComoJogar()
    {
        SceneManager.LoadScene("ComoJogar");
    }
}
