using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrimeNumbers2 : MonoBehaviour
{
    public InputField inputField;
    public TMP_Text ergebnisText;
    public TMP_Text resultText;

    public void PruefePrimzahl()
    {
        
        string eingabe = inputField.text;
        int zahl;

        try
        {
            
            int intValue = int.Parse(inputField.text);

            
            resultText.text = "Eingabe ist eine ganze Zahl: " + intValue;
        }
        catch (System.FormatException)
        {
            
            resultText.text = "Achtung! Eingabe ist keine ganze Zahl (String)";
        }


        if (int.TryParse(eingabe, out zahl))
        {
            
            if (IstPrimzahl(zahl))
            {
                ergebnisText.text = zahl + " ist eine Primzahl!";
            }
            else
            {
                ergebnisText.text = zahl + " ist keine Primzahl (Falsch)!";
            }
        }
        else
        {
            ergebnisText.text = "Ungültige Eingabe";
        }
    }

    // Funktion zur Überprüfung, ob eine Zahl eine Primzahl ist
    private bool IstPrimzahl(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        // Überprüfe, ob n durch irgendeine Zahl von 2 bis zur Wurzel von n ohne Rest teilbar ist
        for (int i = 2; i <= Mathf.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
