using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        const int MAX_HEALTH_POINTS = 100;

        int healthPoints = 10;

        int potionHealthPoints = 5;

        healthPoints += potionHealthPoints;

        float positionX = .9f;

        bool isRealLife = true;

        string playerName = "Michel";

        healthPoints = int.Parse("255"); // convertie la chaine de caractere (string), en nombre (int)

        string debugString = $"Player's health points : {healthPoints}"; // Le $ permet l'Interpolation, ajouter une variable dans un string
        debugString = "Player's health points :" + healthPoints; // Concaténation

        (healthPoints, potionHealthPoints ) = ( potionHealthPoints, healthPoints ) ; // Permet d'associer des valeurs au variables, en l'occurence on inverse les valeurs des 2 variables
    
        float healthPointsFloat = (float)healthPoints;

        var manaPoints = 10; // var permet l'inférence de type, en l'occurence il comprend que la variable est un int

       Vector2 myVector = Vector2.zero;
        float vectorAdd = myVector.AddCoordinates();
    
    }

    int Increment(int value) // Cette ligne s'appel la signature de la fonction, avec sont type, puis son nom, et enfin ses parametres entre parentheses
    {
        return value + 1;
    }

    int Decrement(int value) 
    { 
        return value - 1; 
    }

    void Method(float value = 10) // en definissant un parametre par defaut, on peut appeler la fonction sans preciser de valeurs
    {

    }

    // en definissant un tableau dans les parametres de cette maniere, je peux rentrer un nombre infini de valeurs en parametres lors de l'appel de la fonction
    void Method2(float value = 1, params int[] values) 
    {

    }

}
