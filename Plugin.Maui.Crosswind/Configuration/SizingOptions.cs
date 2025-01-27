namespace Plugin.Maui.Crosswind.Configuration;

public class SizingOptions
{
    private readonly Dictionary<string, object> _values;

    public SizingOptions()
    {
        _values = new Dictionary<string, object>
        {
            { "xs", 12 },
            { "sm", 14 },
            { "md", 16 },
            { "lg", 18 },
            { "xl", 20 },
            { "2xl", 24 },
            { "3xl", 30 },
            { "4xl", 36 },
            { "5xl", 48 },
            { "6xl", 64 }
        };
    }

    public SizingOptions AddCustom(string key, int value)
    {
        _values[key] = value;
        return this;
    }

    public Dictionary<string, object> GetValues() => _values;
}
