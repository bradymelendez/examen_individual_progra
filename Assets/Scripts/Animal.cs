using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Animal : MonoBehaviour, IComprable
{
    public string Nombre;

    public void ColocarEnZonaAnimales()
    {
        Debug.Log($"Colocando {Nombre} en la zona de animales.");
    }

    public void Vender()
    {
        Debug.Log($"Vendiendo {Nombre}.");
    }

    public void Comprar()
    {
        Debug.Log($"Comprando {Nombre}.");
    }

    public void RealizarAccion()
    {
        ColocarEnZonaAnimales();
    }
}