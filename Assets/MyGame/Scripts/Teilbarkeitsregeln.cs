using UnityEngine;
using TMPro;

public class Teilbarkeitsregeln : MonoBehaviour
{
    public int randomInt;
    public TextMeshProUGUI myNumber;
    public TextMeshProUGUI Correct;

    public void RandomNumber()
    {
        randomInt = Random.Range(0, 100);
        myNumber.text = randomInt.ToString();
    }


    public void Teilbarkeit(int zahl)
    {
        if (zahl == 2)
        {
            if (randomInt % 2 == 0)
            {
                Correct.text = "richtig!";
            }
            else
            {
                Correct.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 3)
        {
            if (randomInt % 3 == 0)
            {
                Correct.text = "richtig!";
            }
            else
            {
                Correct.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 5)
        {
            if (randomInt % 5 == 0)
            {
                Correct.text = "richtig!";
            }
            else
            {
                Correct.text = "falsch!";
            }
            RandomNumber();
        }

        if (zahl == 7)
        {
            if (randomInt % 7 == 0)
            {
                Correct.text = "richtig!";
            }
            else
            {
                Correct.text = "falsch!";
            }
            RandomNumber();
        }
        if (zahl == 9)
        {
            if (randomInt % 9 == 0)
            {
                Correct.text = "richtig!";
            }
            else
            {
                Correct.text = "falsch!";
            }
            RandomNumber();
        }
    }
}