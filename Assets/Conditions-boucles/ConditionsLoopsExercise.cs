using Unity.VisualScripting;
using UnityEngine;

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
        Debug.Log("Exo 1");
        CheckUserAge(_userAge);

        Debug.Log("Exo 2");
        DrawTriangle(_starTriangleSize);

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
        else if (ageToCheck < 64) 
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

}
