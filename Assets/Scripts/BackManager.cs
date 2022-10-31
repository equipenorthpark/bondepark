using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLugarDoJogo;

    public void Mapa()
    {
        SceneManager.LoadScene("Mapa");
    }

}
