using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public CounterControllerSemillas counterController;
    public GameObject objectToActivate;
    public GameObject bar;

    private bool canInteract = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = false;
        }
    }

    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {
            AttemptObjectActivation();
        }
    }

    void AttemptObjectActivation()
    {
        if (counterController.counter > 0 && objectToActivate != null)
        {
            bar.SetActive(true);
            objectToActivate.SetActive(true);
            counterController.DecreaseCounter2();
        }
    }
}
