namespace Plugin.Maui.Crosswind.Configuration;

/// <summary>
/// Configuration class for color palettes.
/// </summary>
public class PaletteOptions
{
    private readonly Dictionary<int, string> _shades = [];

    /// <summary>
    /// Adds a shade to the palette.
    /// </summary>
    /// <param name="shade">The shade number (e.g., 100, 200).</param>
    /// <param name="color">The color value (e.g., "#ffffff").</param>
    public void AddShade(int shade, string color)
    {
        if (!_shades.ContainsKey(shade))
        {
            _shades.Add(shade, color);
        }
        else
        {
            throw new ArgumentException($"Shade {shade} is already defined in this palette.");
        }
    }

    /// <summary>
    /// Retrieves the configured shades.
    /// </summary>
    /// <returns>A dictionary of shades and their corresponding color values.</returns>
    public Dictionary<int, string> GetShades() => _shades;
}