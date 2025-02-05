namespace Plugin.Maui.Crosswind.Configuration;

public class ColorOptions
{
    private readonly Dictionary<string, object> _values;

    public ColorOptions()
    {
        _values = [];
    }

    public ColorOptions AddCustom(string key, string value)
    {
        _values[key] = value;
        return this;
    }

    public ColorOptions AddPalette(string key, Action<PaletteOptions> configure)
    {
        var paletteOptions = new PaletteOptions();
        configure(paletteOptions);
                
        _values[key] = paletteOptions.GetShades();
        
        return this;
    }

    public Dictionary<string, object> GetValues() => _values;
}
