using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterControllerSemillas : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public TextMeshProUGUI anotherValueText;
    private int counter = 0;
    private int anotherValue = 500;

    private void Start()
    {
        UpdateAnotherValueText();
    }
    public void IncreaseCounter()
    {
        counter++;
        UpdateCounterText();
        if (anotherValue < 10000)
        {
            anotherValue -= 60;
            UpdateAnotherValueText();
        }
    }

    public void DecreaseCounter()
    {
        if (counter > 0)
        {
            counter--;
            UpdateCounterText();

            if (anotherValue < 10000)
            {
                anotherValue += 50;
                UpdateAnotherValueText();
            }
        }
    }

    void UpdateCounterText()
    {
        counterText.text = "Semillas : " + counter.ToString();
    }

    void UpdateAnotherValueText()
    {
        anotherValueText.text = "Monedas : " + anotherValue.ToString();
    }
}
