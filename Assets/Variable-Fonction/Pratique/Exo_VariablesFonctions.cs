using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exo_VariablesFonctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Exo 1
        int tata = 5;
        int toto = 7;

        (tata, toto) = (toto, tata);

        Debug.Log($"tata = {tata}, toto = {toto}");

        int titi = 2;
        float tutu = 6.34f;

        (titi, tutu) = ((int)tutu, (float)titi);

        Debug.Log($"titi = {titi}, tutu = {tutu}");

        //Exo 2
        int chiffre = 6;
        char caractere = (char)(chiffre + '0');

        Debug.Log($"caractere = {caractere}");

        if (caractere is char) //vérifie que la variable est de type char
        {
            Debug.Log("La variable caractere est un char");
        }


        //Exo 3
        //J'ai définie plusieurs fois la fonction Add pour la surchargé et qu'elle soit ainsi fonctionnelle pour les int et les float.
        int integer1 = 4;
        int integer2 = 5;

        float float1 = 4.44f;
        float float2 = 5.55f;

        int sum1 = Add(integer1, integer2);
        float sum2 = Add(float1, float2);

        Debug.Log($"résultat de la somme1 = {sum1}");
        Debug.Log($"résultat de la somme2 = {sum2}");

        //Exo4
        int product;

        Multiply(integer1, integer2, out product);

        Debug.Log($"résultat de la multiplication = {product}");

        //Exo5

        int minor = 17;
        int eighteen = 18;
        int major = 19;

        IsMajor(minor);
        IsMajor(eighteen);
        IsMajor(major);

        //Exo6
        int intValue = 9;
        intValue.AddInt(10);
        Debug.Log($"Après la somme, intValue est égale à = {intValue}");
    }

    int truc = 4;

    int Add(int value1, int value2)
    {
        return value1 + value2;
    }

    float Add(float value1, float value2)
    {
        return value1 + value2;
    }

    int Multiply(int value1, int value2, out int result)
    {
        return result = value1 * value2;

    }
    void IsMajor(int age) 
    {
        Debug.Log($"Is Major = {(age >= 18)}");
    }
}
