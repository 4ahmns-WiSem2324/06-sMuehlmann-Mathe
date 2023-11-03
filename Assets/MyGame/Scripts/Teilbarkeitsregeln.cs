using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Teilbarkeitsregeln : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI zahl1;
    public TextMeshProUGUI trueFalse;

    public void RandomNumber()
    {
        number = Random.Range(0, 100);
        zahl1.text = number.ToString();
    }


    public void Teilbarkeit(int zahl)
    {
        if (zahl == 2)
        {
            if (number % 2 == 0)
            {
                trueFalse.text = "richtig!";
            }
            else
            {
                trueFalse.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 3)
        {
            if (number % 3 == 0)
            {
                trueFalse.text = "richtig!";
            }
            else
            {
                trueFalse.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 5)
        {
            if (number % 5 == 0)
            {
                trueFalse.text = "richtig!";
            }
            else
            {
                trueFalse.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 7)
        {
            if (number % 7 == 0)
            {
                trueFalse.text = "richtig!";
            }
            else
            {
                trueFalse.text = "falsch!";
            }
            RandomNumber();
        }
        if (zahl == 9)
        {
            if (number % 9 == 0)
            {
                trueFalse.text = "richtig!";
            }
            else
            {
                trueFalse.text = "falsch!";
            }
            RandomNumber();
        }
    }
}