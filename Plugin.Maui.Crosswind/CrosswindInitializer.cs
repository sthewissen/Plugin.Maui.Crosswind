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

            // Always add the CSS, it's our main method of styling.
            var stylesheet = InitCssFromResource("styles.css");
            stylesheet = CssParser.Parse(options, stylesheet);
    
            // Take the string and add the styles.
            using var reader = new StringReader(stylesheet);
            Application.Current?.Resources.Add(StyleSheet.FromReader(reader));
           
            // Create a resource dictionary for all of our variables.
            PopulateVariables(options);
            
            // Add the dictionary containing fixes for CSS.
            Application.Current?.Resources.MergedDictionaries.Add(new Resources.CwFixedResources());
        }
    }

    private static void PopulateVariables(CrosswindOptions options)
    {
        var dictionaryVariables = new Resources.CwVariables();
        
        // Go through the defaults
        foreach (var category in Constants.Defaults)
        {
            var categoryName = category.Key;
            foreach (var entry in category.Value)
            {
                var key = $"cw_{categoryName}_{entry.Key}";

                switch (entry.Value)
                {
                    case double d:
                        dictionaryVariables.Add(key, d);
                        break;
                    case string s:
                        dictionaryVariables.Add(key, s);
                        break;
                    // Add more cases if we extend the data model later
                    default:
                        // Optionally handle unsupported types
                        break;
                }
            }
        }
        
        // Check options for overrides + additions
        foreach (var category in options)
        {
            foreach (var entry in category.Value)
            {
                var key = $"cw_{category.Key}_{entry.Key.Replace("-", "_")}";

                switch (entry.Value)
                {
                    case double d:
                        dictionaryVariables[key] = d;
                        break;
                    case string s:
                        dictionaryVariables[key] = s;
                        break;
                    case Dictionary<int, string> dict:
                        foreach (var item in dict)
                        {
                            dictionaryVariables[$"{key}_{item.Key}"] = item.Value;
                        }
                        break;
                    // Add more cases if we extend the data model later
                    default:
                        // Optionally handle unsupported types
                        break;
                }
            }
        }
        
        Application.Current?.Resources.MergedDictionaries.Add(dictionaryVariables);
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
