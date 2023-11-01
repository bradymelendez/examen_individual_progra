using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public CharacterController controler;
    public float speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controler.Move(move*speed*Time.deltaTime);

    }

    public void InteractuarConElemento(IComprable elemento)
    {
        elemento.RealizarAccion();
    }
}
