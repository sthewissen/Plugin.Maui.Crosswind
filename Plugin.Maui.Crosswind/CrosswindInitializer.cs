using Microsoft.Maui.Controls.StyleSheets;
using System.IO;
using System.Reflection;

namespace Plugin.Maui.Crosswind;

public static class CrosswindInitializer
{
    public static void Init(CrosswindOptions? options = null)
    {
        // Merge Crosswind styles into the app's resource dictionary
        if (Application.Current?.Resources != null)
        {
            var stylesheet = InitCssFromResource("styles.css");

            // Override styles based on options....
            options ??= new CrosswindOptions();

            // Validate the options, throws an exception if invalid
            options.Validate();

            stylesheet = CssParser.Parse(options, stylesheet);

            // Take the string and add the styles.
            using var reader = new StringReader(stylesheet);
            Application.Current?.Resources.Add(StyleSheet.FromReader(reader));
        }
    }

    private static string InitCssFromResource(string name)
    {
        // Determine path
        var assembly = Assembly.GetExecutingAssembly();
        var resourcePath = assembly.GetManifestResourceNames().SingleOrDefault(str => str.EndsWith(name)) ?? throw new ArgumentException("No valid CSS file found!");
        using var stream = assembly.GetManifestResourceStream(resourcePath) ?? throw new ArgumentException("No valid CSS file found!");
        using var reader = new StreamReader(stream);

        // Add the stylesheet to the app's resources
        return reader.ReadToEnd();
    }
}
