namespace BlazorMinimalSS.Models;

public class AuthomatedLog(float minValue, float maxValue)
{
    readonly Random rand = new(DateTime.Now.Millisecond);

    double seed = 0.0F;

    public float NextValue()
    {
        seed = Math.Round(Math.Min(Math.Max(seed + (0.1 - rand.NextDouble() / 5.0), -1), 1), 4);
        return (maxValue - minValue) * 0.5F * ((float)seed + 1.0F) + minValue;
    }
}

