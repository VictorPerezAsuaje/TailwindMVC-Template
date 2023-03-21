namespace BlazorComponents.Library;

public class ColorOverrider
{
    static Dictionary<string, string> _OverriddenColors { get; set; } = new();

    public void OverrideColors(Action<Dictionary<string, string>> variableColorOverrides)
       => variableColorOverrides?.Invoke(_OverriddenColors);

    internal string? TryGetColor(string color)
    {
        _OverriddenColors.TryGetValue(color, out string? overriddenColor);
        return overriddenColor;
    }

    public Dictionary<string, string> GetOverridenColors() => _OverriddenColors;
}

public static class TailwindStylesServices
{
    public static IServiceCollection AddTailwindStylesServices(this IServiceCollection services, Action<Dictionary<string, string>> overridenColorConfig = null)
    { 
        ColorOverrider colorOverrider = new ColorOverrider();
        colorOverrider.OverrideColors(overridenColorConfig);

        services.AddSingleton(colorOverrider);
        return services;
    }
}
