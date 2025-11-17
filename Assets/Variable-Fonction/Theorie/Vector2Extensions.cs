using UnityEngine;

public static class Vector2Extensions
{
    public static float AddCoordinates(this Vector2 vector2)
    {
        return vector2.x * vector2.y;
    }
}
