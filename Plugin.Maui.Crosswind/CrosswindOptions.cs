using System.Text.RegularExpressions;

namespace Plugin.Maui.Crosswind;

public partial class CrosswindOptions : Dictionary<string, Dictionary<string, object>>
{
     // Schema defining valid keys and their allowed value types
    private static readonly Dictionary<string, Type[]> Schema = new()
    {
        { "spacing", new[] { typeof(int) } },   // "spacing" values must be int
        { "sizing", new[] { typeof(int) } },    // "sizing" values must be int
        { "colors", new[] { typeof(string), typeof(Dictionary<string, object>) } } // "colors" can be string or nested dictionary
        
        // TODO: Add future keys with their valid types here
    };

    /// <summary>
    /// Validates the options dictionary against the schema.
    /// </summary>
    /// <exception cref="InvalidOperationException">An exception is thrown if the options are invalid.</exception>
    internal void Validate()
    {
         // Step 1: Validate top-level keys
        foreach (var key in this.Keys)
        {
            if (!Schema.ContainsKey(key))
            {
                throw new ArgumentException($"Invalid top-level key: '{key}'. Valid keys are: {string.Join(", ", Schema.Keys)}.");
            }
        }

        // Step 2: Validate sub-level keys and their values
        var validCssClassNamePattern = IsValidCssClassNameRegex();

        foreach (var (category, subDict) in this)
        {
            var validTypes = Schema[category]; // Get the valid types for this category

            foreach (var (subKey, value) in subDict)
            {
                // Check if sub-key is a valid CSS class name
                if (!validCssClassNamePattern.IsMatch(subKey))
                {
                    throw new ArgumentException($"Invalid CSS class name: '{subKey}' in category '{category}'. Must match: {validCssClassNamePattern}.");
                }

                // Check if the value matches any of the valid types
                if (value == null || !validTypes.Any(t => t.IsInstanceOfType(value)))
                {
                    var validTypeNames = string.Join(" or ", validTypes.Select(t => t.Name));
                    throw new ArgumentException($"Invalid value type for key '{subKey}' in category '{category}'. Expected type(s): {validTypeNames}, but got {value?.GetType().Name ?? "null"}.");
                }
            }
        }


    }

    [GeneratedRegex(@"^[a-zA-Z_][a-zA-Z0-9_-]*$")]
    private static partial Regex IsValidCssClassNameRegex();
}