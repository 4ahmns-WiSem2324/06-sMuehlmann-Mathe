using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zahlenarten : MonoBehaviour
{
    public float randomFloat;
    public int zufall;
    public TextMeshProUGUI Zahlen, richtigText;
    public int newInt;


    private void Start()
    {
        Next();
    }

    public void ZahlenArt(float Zahl)
    {
        if (Zahl > 0 && Mathf.Approximately(Zahl, Mathf.Floor(Zahl)))
        {
            newInt = 2;
        }
        else if (Mathf.Approximately(Zahl, Mathf.Floor(Zahl)))
        {
            newInt = 1;
        }
        else
        {
            newInt = 3;
        }
    }

    void Next()
    {
        zufall = Random.Range(0, 2);
        if (zufall == 1)
        {
            randomFloat = Random.Range(-100, 100);
        }
        else
        {
            randomFloat = Random.value * 100;
        }
        Zahlen.text = randomFloat.ToString();
        ZahlenArt(randomFloat);
    }

    public void TrueFalse(int a)
    {
        if (a == newInt)
        {
            richtigText.text = "Richtig";
        }
        else
        {
            richtigText.text = "Falsch";
        }
        Next();
    }


}