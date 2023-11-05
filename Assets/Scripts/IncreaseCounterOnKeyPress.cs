using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCounterOnKeyPress : MonoBehaviour
{
    public CounterControllerSemillas counterController;
    private bool playerInside = false;

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            IncreaseCounterRandomlyAndDestroy();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }

    void IncreaseCounterRandomlyAndDestroy()
    {
        int randomIncrement = Random.Range(2, 4);
        for (int i = 0; i < randomIncrement; i++)
        {
            counterController.IncreaseCounter2();
        }
        Destroy(gameObject);
    }
}
