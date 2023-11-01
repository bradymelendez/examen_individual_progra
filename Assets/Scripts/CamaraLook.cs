using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook : MonoBehaviour
{
    public float sensibilidad = 100f;
    public Transform player;
    float rotacion = 0;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;

        rotacion -= mouseY;
        rotacion = Mathf.Clamp(rotacion, -90F, 90);

        transform.localRotation = Quaternion.Euler(rotacion, 0F, 0f);

        player.Rotate(Vector3.up*mouseX);

    }
}
