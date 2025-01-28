namespace Plugin.Maui.Crosswind.Configuration;

public class FontOptions
{
    private readonly Dictionary<string, object> _values;

    public FontOptions()
    {
        _values = new Dictionary<string, object>
        {
            { "sans-serif", "sans-serif" },
            { "serif", "serif" },
            { "mono", "monospace" }
        };
    }

    public FontOptions AddCustom(string key, string value)
    {
        _values[key] = value;
        return this;
    }

    public Dictionary<string, object> GetValues() => _values;
}
