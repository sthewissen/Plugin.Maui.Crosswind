using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;

namespace Plugin.Maui.Crosswind;

public static class CrosswindInitializer
{
    /// <summary>
    /// Initialize Crosswind with the default options.
    /// </summary>
    /// <param name="options">Custom options to override the default options.</param>
    public static void Init(CrosswindOptions? options = null)
    {
        // Merge Crosswind styles into the app's resource dictionary
        if (Application.Current?.Resources != null)
        {
            // Override styles based on options....
            options ??= new CrosswindOptions();

            // Validate the options, throws an exception if invalid
            options.Validate();

            if(options.UseCss)
            {
                var stylesheet = InitCssFromResource("styles.css");
                stylesheet = CssParser.Parse(options, stylesheet);
    
                // Take the string and add the styles.
                using var reader = new StringReader(stylesheet);
                Application.Current?.Resources.Add(StyleSheet.FromReader(reader));
            }
            else
            {
                // TODO: Use the Resource Dictionary approach
                
            }
        }
    }

    /// <summary>
    /// Initialize Crosswind with our custom CSS stylesheet.
    /// </summary>
    /// <param name="name">The name of the CSS file to load.</param>
    /// <returns>A string of the CSS content.</returns>
    /// <exception cref="ArgumentException">An exception is thrown if the CSS file is not found.</exception>
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
