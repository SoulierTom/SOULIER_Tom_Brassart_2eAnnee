using System;
using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class Conditions_Loops : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Condition if
        if (3>1)
        {
            Debug.Log("oui");
        }

        // Condition if pour comparer strictement des floats
        if (Mathf.Approximately(1.0f, 10.0f / 10.0f))
        {
            print("The values are approximately the same");
        }

        // Condition Switch
        double measurement = 10.0;
        switch (measurement)
        {
            case < 0.0:
                Console.WriteLine($"Measured value is {measurement}; too low.");
                break;

            case > 15.0:
                Console.WriteLine($"Measured value is {measurement}; too high.");
                break;

            case double.NaN:
                Console.WriteLine("Failed measurement.");
                break;

            default:
                Console.WriteLine($"Measured value is {measurement}.");
                break;
        }

        // Condition en une ligne : ternaire
        string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

        Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
        Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!

        // Operateur de test à null (nom d’usage)
        string playerName = null;
        playerName = playerName ?? "none";
        playerName ??= "none"; // Diminutif de la ligne du dessus

        // Boucle For() qui s'execute 10 fois
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 1) // Vérifie si le nombre est impaire
            {
                continue;   // Continue permet de revenir au début de la boucle sans éxécuter le code en-dessous
            }

            // éxécution sur un nombre pair
        }

        // Permet d'affecter null à une variable valeur
        Nullable<int> y = null;
        int? x = null; //diminutif
    }

   
}
