using JetBrains.Annotations;
using UnityEngine;

public class Wizard : Character
{
    private new int maxHealth = 10;
    private new string characterName = "Harry";

    private int manaPoints = 15;

    public override void Move(Vector3 input)
    {
        //Méthode permettant de se déplacer au clavier
    }

    public void CastFireball(IDestructible[] destructibleArray)
    {
        //La boule de feu détruit tous les éléments de destructibleArray
    }
}
