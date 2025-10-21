using System;

namespace WhereWorldsFade.Scripts;

public struct Vector2D(float x, float y)
{
    public float x = x;
    public float y = y;

    public override string ToString() => $"({x}, {y})";
    
    public static Vector2D operator +(Vector2D operand) => operand;
    public static Vector2D operator -(Vector2D operand)
        => new(-operand.x, -operand.y);
    public static Vector2D operator +(Vector2D left, Vector2D right)
        => new(left.x + right.x, left.y + right.y);
    public static Vector2D operator -(Vector2D left, Vector2D right)
        => new(left.x - right.x, left.y - right.y);
    public static Vector2D operator *(Vector2D left, Vector2D right)
        => new(left.x * right.x, left.y * right.y);
    public static Vector2D operator /(Vector2D left, Vector2D right)
    {
        if (right.x == 0 || right.y == 0)
            throw new DivideByZeroException();
        return new(left.x / right.x, left.y / right.y);
    }
    public static float Dot(Vector2D left, Vector2D right)
        => left.x * right.x + left.y * right.y;
}