using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class ConditionsLoopsExercise : MonoBehaviour
{
    [SerializeField]
    private int _starTriangleSize = 2;
    [SerializeField]
    private int _userAge = 2;
    [SerializeField]
    private int _factorialValue = 2;

    
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        Debug.Log("Exo 1 : ");
        CheckUserAge(_userAge);

        Debug.Log("Exo 2 : ");
        DrawTriangle(_starTriangleSize);

        Debug.Log("Exo 3 : ");
        PrintFactorial(_factorialValue);

        Debug.Log("Exo 4 : ");
        BubbleSort();
    }

    void CheckUserAge(int ageToCheck)
    {
        if (ageToCheck < 0)
        {
            Debug.Log("Age de l'utilisateur invalide");
        }
        else if (ageToCheck < 18) 
        { 
            Debug.Log("Utilisateur mineur"); 
        }
        else if (ageToCheck < 1000) // La France de Macron
        { 
            Debug.Log("Utilisateur majeur"); 
        }
        else 
        { 
            Debug.Log("Utilisateur à la retraite"); 
        }
    }

    void DrawTriangle(int n)
    {
        string space = " ";
        string star = "*";
        string back = "\n";
        string text = "";

        if (n > 0)
        {
            for (int l = 0; l < n; l++)
            {
                for (int e = 0; e < ((n - 1) - l); e++)
                {
                    text = text + space;
                }

                for (int s = 0; s < (n - (n - 1) + 2 * l); s++)
                {
                    text = text + star;
                }

                text = text + back;
            }

            Debug.Log(text);
        }

        else
        {
            Debug.Log("Nombre de ligne invalide");
        }
        
    }

    void PrintFactorial(int f)
    {
        int currentValue = 1;

        if (f >= 0)
        {
            for (int i = f; i > 0; i--)
            {
                currentValue = currentValue * i;
            }

            Debug.Log("La factorielle de " + f + " est : " + currentValue);
        }
        else
        {
            Debug.Log("Factorielle de nombre négatifs non définie.");
        }
    }

    void BubbleSort()
    {
        // Création et initialisation du tableau d'objets
        int[] tab = new int[8];

        tab[0] = 84;
        tab[1] = 6;
        tab[2] = 41;
        tab[3] = 157;
        tab[4] = 64;
        tab[5] = 29;
        tab[6] = 1;
        tab[7] = 42;
       
        Debug.Log("Tableau d'origine : " + tab[0] + ", " + tab[1] + ", " + tab[2] + ", " + tab[3] + ", " + tab[4] + ", " + tab[5] + ", " + tab[6] + ", " + tab[7]);

        for(int i = 0; i < tab.Length - 1; i++) // Reproduit le balayage de vérification en boucle.
        { 
            for (int j = 0; j < tab.Length - (1 + i); j++) // Effectue le balayage, de la première valeur jusqu'à la dernière (le balayage s'arrete une valeur plus tot à chaque boucle).
            {
                if (tab[j] > tab[j + 1]) // Vérifie si la valeur est supérieure à celle qui la suit.
                {
                    (tab[j], tab[j + 1]) = (tab[j + 1], tab[j]); // Intervertie les valeurs
                }
            }
        }

        Debug.Log("Tableau dans l'ordre croissant : " + tab[0] + ", " + tab[1] + ", " + tab[2] + ", " + tab[3] + ", " + tab[4] + ", " + tab[5] + ", " + tab[6] + ", " + tab[7]);
    }
}

    
