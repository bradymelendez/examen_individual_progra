using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CounterControllerAnimal : MonoBehaviour
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
            anotherValue -= 100;
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
                anotherValue += 100;
                UpdateAnotherValueText();
            }
        }
    }

    void UpdateCounterText()
    {
        counterText.text = "Animales : " + counter.ToString();
    }

    void UpdateAnotherValueText()
    {
        anotherValueText.text = "Monedas : " + anotherValue.ToString();
    }
}
