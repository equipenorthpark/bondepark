using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType
    {
        ChaveDeFenda,
        ColherDePedreiro,
        CortadorDeGrama,
        Enxada,
        Luva,
        Martelo,
        Pincel,
        Prego,
        Pá,
        Rastelo,
        Rolo,
        SacoDeLixo,
    }

    public ItemType itemType;
    public int amount;


    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.ChaveDeFenda:     return ItemAssets.Instance.chaveDeFendaSprite;
            case ItemType.ColherDePedreiro: return ItemAssets.Instance.colherDePedreiroSprite;
            case ItemType.CortadorDeGrama:  return ItemAssets.Instance.cortadorDeGramaSprite;
            case ItemType.Enxada:           return ItemAssets.Instance.enxadaSprite;
            case ItemType.Luva:             return ItemAssets.Instance.luvaSprite;
            case ItemType.Martelo:          return ItemAssets.Instance.marteloSprite;
            case ItemType.Pincel:           return ItemAssets.Instance.pincelSprite;
            case ItemType.Prego:            return ItemAssets.Instance.pregoSprite;
            case ItemType.Pá:               return ItemAssets.Instance.páSprite;
            case ItemType.Rastelo:          return ItemAssets.Instance.rasteloSprite;
            case ItemType.Rolo:             return ItemAssets.Instance.roloSprite;
            case ItemType.SacoDeLixo:       return ItemAssets.Instance.sacoDeLixoSprite;
        }
    }

}
