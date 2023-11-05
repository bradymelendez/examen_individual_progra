using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectActivatorWithTimer : MonoBehaviour
{
    public GameObject objectToActivate;
    public float activationTime = 5.0f; 
    public Image progressBar; 
    [Header("Tiempo Restante")]
    public float remainingTime;

    private bool activated = false;
    private float timer = 0.0f;

    void Update()
    {
        if (!activated)
        {
            timer += Time.deltaTime;
            float progress = 1 - (timer / activationTime); 

            progressBar.fillAmount = progress; 
            remainingTime = activationTime - timer; 

            if (timer >= activationTime)
            {
                ActivateObject();
            }
        }
    }

    void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
            activated = true;
        }
    }
}
