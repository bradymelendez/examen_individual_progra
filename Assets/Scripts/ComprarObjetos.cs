using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComprarObjetos: MonoBehaviour
{
    public CounterControllerSemillas counterController;
    public GameObject objetoAActivar;
    public GameObject objetoBActivar;

    public void CheckAnotherValue()
    {
        if (counterController.anotherValue >= 1500)
        {
            counterController.anotherValue -= 1500;
            counterController.UpdateAnotherValueText(); 

            objetoAActivar.SetActive(true);
        }
    }
    public void CheckAnotherValue2()
    {
        if (counterController.anotherValue >= 2000)
        {
            counterController.anotherValue -= 2000;
            counterController.UpdateAnotherValueText();

            objetoBActivar.SetActive(true);
        }
    }
}
