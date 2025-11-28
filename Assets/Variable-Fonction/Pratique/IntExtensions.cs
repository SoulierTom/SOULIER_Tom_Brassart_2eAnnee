using Unity.VisualScripting;
using UnityEngine;

public static class IntExtensions
{
    public static void AddInt(ref this int valueOrigin, int valueToAdd)
    {
        valueOrigin = valueOrigin + valueToAdd;
    }
}
