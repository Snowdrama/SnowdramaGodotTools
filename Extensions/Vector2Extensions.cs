using System;
using System.Collections;
using System.Collections.Generic;
using Godot;
public static class Vector2Extensions{
    private static float PI = 3.14159265358979f;
    private static float Deg2Rad = PI / 180;
    private static float Rad2Deg = 180 / PI;
    public static Vector2 VectorFromAngleRads(float angle)
    {
        Vector2 V = new Vector2();
        V.X = Mathf.Cos(angle);
        V.Y = Mathf.Sin(angle);
        return V.Normalized();
    }
    public static Vector2 VectorFromAngle(float angle)
    {
        angle = Deg2Rad * angle;
        return VectorFromAngleRads(angle).Normalized();
    }

    public static Vector2I FloorToInt(this Vector2 dir)
    {
        return new Vector2I(Mathf.FloorToInt(dir.X), Mathf.FloorToInt(dir.Y));
    }

    public static Vector2I CeilToInt(this Vector2 dir)
    {
        return new Vector2I(Mathf.CeilToInt(dir.X), Mathf.CeilToInt(dir.Y));
    }

    public static Vector2I RoundToInt(this Vector2 dir)
    {
        return new Vector2I(Mathf.RoundToInt(dir.X), Mathf.RoundToInt(dir.Y));
    }

    public static Vector2 Floor(this Vector2 dir)
    {
        return new Vector2(Mathf.Floor(dir.X), Mathf.Floor(dir.Y));
    }

    public static Vector2 Ceil(this Vector2 dir)
    {
        return new Vector2(Mathf.Ceil(dir.X), Mathf.Ceil(dir.Y));
    }

    public static Vector2 Round(this Vector2 dir)
    {
        return new Vector2(Mathf.Round(dir.X), Mathf.Round(dir.Y));
    }

    public static Vector2I Clamp(this Vector2I val, Vector2I min, Vector2I max)
    {
        return new Vector2I(Mathf.Clamp(val.X, min.X, max.X), Mathf.Clamp(val.Y, min.Y, max.Y));
    }
    public static Vector2 Clamp(this Vector2 val, Vector2 min, Vector2 max)
    {
        return new Vector2(Mathf.Clamp(val.X, min.X, max.X), Mathf.Clamp(val.Y, min.Y, max.Y));
    }

    public static float AngleFromVector(this Vector2 dir)
    {
        float angle = Rad2Deg * Mathf.Atan2(dir.Y, dir.X);
        if (angle < 0)
        {
            angle += 360;
        }
        return angle;
    }

    public static float AngleFromVectorRads(this Vector2 dir)
    {
        var angle = Mathf.Atan2(dir.Y , dir.X);
        if (angle < 0)
        {
            angle += 2 * PI;
        }
        return angle;
    }

    public static Vector2 PerpendicularClockwise(this Vector2 vec)
    {
        return new Vector2(vec.Y, -vec.X);
    }
    public static Vector2 Lerp(Vector2 start, Vector2 end, float t)
    {
        return new Vector2(Mathf.Lerp(start.X, end.X, t), Mathf.Lerp(start.Y, end.Y, t));
    }

    public static Vector2 PerpendicularCounterClockwise(this Vector2 vec)
    {
        return new Vector2(-vec.Y, vec.X);
    }
    public static float AngleTo(this Vector2 self, Vector2 to)
    {
        Vector2 direction = to - self;
        float angle = Mathf.Atan2(direction.Y, direction.X) * Rad2Deg;
        if (angle < 0f) angle += 360f;
        return angle;
    }
}