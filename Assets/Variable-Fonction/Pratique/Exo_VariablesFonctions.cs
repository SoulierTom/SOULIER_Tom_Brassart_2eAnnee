using UnityEngine;

public class Exo_VariablesFonctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int tata = 5;
        int toto = 7;

        (tata, toto) = (toto, tata);

        Debug.Log($"tata = {tata}, toto = {toto}");

        int titi = 2;
        float tutu = 6.34f; 

        //(titi, tutu) = (tutu, titi);

         Debug.Log($"titi = {tata}, tutu = {tutu}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
