using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite chaveDeFendaSprite;
    public Sprite colherDePedreiroSprite;
    public Sprite cortadorDeGramaSprite;
    public Sprite enxadaSprite;
    public Sprite luvaSprite;
    public Sprite marteloSprite;
    public Sprite pincelSprite;
    public Sprite pregoSprite;
    public Sprite páSprite;
    public Sprite rasteloSprite;
    public Sprite roloSprite;
    public Sprite sacoDeLixoSprite;
}
