using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrimeNumbers : MonoBehaviour
{
    public TMP_Text numberText;
    public TMP_Text resultText;
    public Button isPrimeButton;
    public Button isNotPrimeButton;

    private int randomNumber;
    private bool isPrime;

    private void Start()
    {
        GenerateRandomNumber();
        isPrimeButton.onClick.AddListener(CheckPrime);
        isNotPrimeButton.onClick.AddListener(CheckNotPrime);
    }

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(2, 100); 
        numberText.text = "Nummer: " + randomNumber;
        resultText.text = ""; 
        isPrime = IsPrime(randomNumber);
    }

    public void CheckPrime()
    {
        if (isPrime)
        {
            
            GenerateRandomNumber();
        }
        else
        {
            resultText.text = "Falsch!";
        }
    }

    public void CheckNotPrime()
    {
        if (!isPrime)
        {
            
            GenerateRandomNumber();
        }
        else
        {
            resultText.text = "Falsch!";
        }
    }

    
    private bool IsPrime(int number)
    {
        

        if (number == 1) return false;
        if (number == 2) return true;

        if (number % 2 == 0) return false;    

        for (int i = 2; i < number; i++)
        { 
            if (number % i == 0) return false;
        }

        return true;
    }
}
