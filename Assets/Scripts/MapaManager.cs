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

    public void Parque()
    {
        SceneManager.LoadScene("Parque");
    }

    public void Campinho()
    {
        SceneManager.LoadScene("Campinho");
    }
}
