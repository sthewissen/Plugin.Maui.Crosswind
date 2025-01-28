﻿namespace Plugin.Maui.Crosswind.Configuration;

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

    public ColorOptions AddCustom(string key, Dictionary<int, string> values)
    {
        _values[key] = values;
        return this;
    }

    public Dictionary<string, object> GetValues() => _values;
}
