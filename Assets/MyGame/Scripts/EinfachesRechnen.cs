using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EinfachesRechnen : MonoBehaviour
{
    public TMP_Text gleichungsText;
    public InputField answerInputField;
    public TMP_Text resultText;

    private int randomInt1;
    private int randomInt2;
    private char operatorChar;
    private int correctResult;

    private void Start()
    {
        RandomNumber();
    }

    public void RandomNumber()
    {
        randomInt1 = Random.Range(1, 11); 
        randomInt2 = Random.Range(1, 11); 
        operatorChar = GetRandomOperator();
        correctResult = CalculateResult(randomInt1, randomInt2, operatorChar);

        gleichungsText.text = $"{randomInt1} {operatorChar} {randomInt2} = ?";
        answerInputField.text = "";
        resultText.text = "";
    }

    public void CheckAnswer()
    {
        string inputText = answerInputField.text.Trim();
        int myResult;

        if (int.TryParse(inputText, out myResult))
        {
            if (myResult == correctResult)
            {
                RandomNumber();
            }
            else
            {
                resultText.text = "Falsch";
            }
        }
        else
        {
            resultText.text = "Falsch";
        }
    }

    private char GetRandomOperator()
    {
        int randomOperator = Random.Range(0, 3); 

        switch (randomOperator)
        {
            case 0:
                return '+';
            case 1:
                return '-';
            case 2:
                return '*';
            default:
                return '+';
        }
    }

    private int CalculateResult(int operand1, int operand2, char operatorChar)
    {
        switch (operatorChar)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            default:
                return 0;
        }
    }
}
