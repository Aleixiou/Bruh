using UnityEngine;

public static class VectorMath
{
    public static Vector2 Rotate(this Vector2 v, float degrees)
    {
        float rad = degrees / 180 * Mathf.PI;

        return new Vector2(
            v.x * Mathf.Cos(rad) - v.y * Mathf.Sin(rad),
            v.x * Mathf.Sin(rad) + v.y * Mathf.Cos(rad)
        );
    }
}