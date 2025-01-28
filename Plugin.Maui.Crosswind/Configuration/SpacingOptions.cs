namespace Plugin.Maui.Crosswind.Configuration;

public class SpacingOptions
{
    private readonly Dictionary<string, object> _values;

    public SpacingOptions()
    {
        _values = new Dictionary<string, object>
        {
            { "1", 4 },
            { "2", 8 },
            { "3", 12 },
            { "4", 16 },
            { "5", 20 },
            { "6", 24 },
            { "7", 28 },
            { "8", 32 }
        };
    }

    public SpacingOptions AddCustom(string key, int value)
    {
        _values[key] = value;
        return this;
    }

    public Dictionary<string, object> GetValues() => _values;
}
