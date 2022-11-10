using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combatejugador : MonoBehaviour
{
   [SerializeField] private float vida;

   [SerializeField] private float maximoVida;

   [SerializeField] private barraenergia barraenergia;

   private void Start()
   {
    vida = maximoVida;
    barraenergia.InicializarBarradeVida(vida);
   }

   public void TomarDaño(float daño)
   {
    vida -= daño;
    barraenergia.CambiarVidaActual(vida);
    if (vida <= 0)
    {
        Destroy(gameObject);
    }
   }
   

   public void Curar(float curacion)
   {
    if ((vida + curacion) > maximoVida)
    {
        vida = maximoVida;
    }
    else
    {
        vida += curacion;
    }
   }
}
