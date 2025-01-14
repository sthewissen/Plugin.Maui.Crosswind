using Microsoft.Maui.Controls.StyleSheets;
using System.IO;
using System.Reflection;

namespace Plugin.Maui.Crosswind;

public static class CrosswindInitializer
{
    public static void Init()
    {
        // Merge Crosswind styles into the app's resource dictionary
        if (Application.Current?.Resources != null)
        {
            InitCssFromResource("styles.css");

            // TODO: Borders (Style, Width, Radius, Color)
            // TODO: Word Break
            // TODO: Vertical Align
            // TODO: Sizing (Width, Height, MaxHeight, MinHeight, MaxWidth, MinWidth, Size)

            // Shadows + Shadow Colors
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Shadows.VisualElementStyles());
        }
    }

    private static void InitCssFromResource(string name)
    {
        // Determine path
        var assembly = Assembly.GetExecutingAssembly();
        var resourcePath = assembly.GetManifestResourceNames().SingleOrDefault(str => str.EndsWith(name));

        if (resourcePath == null)
            throw new ArgumentException("No valid CSS file found!");

        using var stream = assembly.GetManifestResourceStream(resourcePath);
        using var reader = new StreamReader(stream);
        Application.Current.Resources.Add(StyleSheet.FromReader(reader));
    }
}
