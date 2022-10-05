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

}
