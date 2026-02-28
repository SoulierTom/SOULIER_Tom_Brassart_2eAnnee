using UnityEngine;
using UnityEngine.UIElements;

public abstract class Character : MonoBehaviour
{
    protected int maxHealth;
    protected int currentHealth;
    protected string characterName;

    public virtual void Move(Vector3 destination)
    {
        //Move to destination.
    }
}
