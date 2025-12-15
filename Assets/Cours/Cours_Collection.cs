using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Cours_Collection : MonoBehaviour
{
   
    enum Day
    {
        Monday = 1 << 0,
        Tuesday = 1 << 1,
        Wednesday = 1 << 2,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        
        Weekend = Saturday | Sunday,
    }

    void Start()
    {
        // Les Tableaux (Arrays)

        int[] exampletArray = new int[10];


        int[] intArray = { 5, 24, 6, 134, 4, 80 };

        int index = intArray[3];

        for (int i = 0; i < exampletArray.Length; i++)
        {
            Debug.Log(exampletArray[i]);
        }

        foreach ( int item in intArray)
        {
            Debug.Log(item);
        }

        // Les listes (Lists)

        List<bool> boolList = new();

        Debug.Log(boolList.Count);
        
        // Les Dictionnaires

        Dictionary<int, string> stringByInt = new ();

        stringByInt[10] = "bonjour";
        stringByInt[2] = "Ca va ?";

        stringByInt[10] = "Salut";

        if (stringByInt.TryGetValue(11, out string stringValue) == false)
        {
            stringByInt[11] = "La peche";
            stringValue = stringByInt[11];
        }


        int[,] twoDimensionIntArray = new int[4, 2];

        for (int i= 0; i < twoDimensionIntArray.GetLength(0); i++)
        {

        }


        Day myDay = Day.Thursday | Day.Monday;

        switch (myDay)
        {
            case Day.Thursday:
            case Day.Friday:
                // Traitement spécifique
                break;
            
            default:
                break;
        }

    }

    
}
