using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zahlenarten : MonoBehaviour
{
    public float r;
    public int zufall;
    public TextMeshProUGUI Zahlen, richtigText;
    public int index;


    private void Start()
    {
        Next();
    }

    public void ZahlenArt(float Zahl)
    {
        if (Zahl > 0 && Mathf.Approximately(Zahl, Mathf.Floor(Zahl)))
        {
            index = 2;
        }
        else if (Mathf.Approximately(Zahl, Mathf.Floor(Zahl)))
        {
            index = 1;
        }
        else
        {
            index = 3;
        }
    }

    void Next()
    {
        zufall = Random.Range(0, 2);
        if (zufall == 1)
        {
            r = Random.Range(-100, 100);
        }
        else
        {
            r = Random.value * 100;
        }
        Zahlen.text = r.ToString();
        ZahlenArt(r);
    }

    public void TrueFalse(int a)
    {
        if (a == index)
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