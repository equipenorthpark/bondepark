using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLugarDoJogoI;
    [SerializeField] private string nomeDoLugarDoJogoII;

    public void CasaNick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Praça()
    {
        SceneManager.LoadScene("Praça");
    }

    public void Lago()
    {

    }
}
