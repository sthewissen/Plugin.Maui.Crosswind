using System.Text;
using System.Text.RegularExpressions;
using Plugin.Maui.Crosswind.Templates;

namespace Plugin.Maui.Crosswind;

/// <summary>
/// Parses CSS content with user-provided options
/// </summary>
public static class CssParser
{
    /// <summary>
    /// Parses the CSS content with the user-provided options
    /// </summary>
    /// <param name="options">The user-provided options</param>
    /// <param name="cssContent">The CSS content to parse</param>
    /// <returns>A string of parsed CSS content</returns>
    public static string Parse(CrosswindOptions options, string cssContent)
    {
        // Step 1: Merge defaults with user-provided options
        var combinedValues = MergeDefaultsWithOverrides(options);

        // Step 2: Replace predefined variables in the CSS content
        cssContent = ReplacePredefinedVariables(cssContent, combinedValues);

        // Step 3: Append new CSS classes for user-added keys
        cssContent += GenerateCustomClasses(combinedValues);

        return cssContent;
    }

    /// <summary>
    /// Replaces predefined variables in the CSS content with the user-provided values.
    /// </summary>
    /// <param name="options">The user-provided options.</param>
    /// <returns>A dictionary of combined values.</returns>
    private static Dictionary<string, Dictionary<string, object>> MergeDefaultsWithOverrides(CrosswindOptions options)
    {
        var combinedValues = new Dictionary<string, Dictionary<string, object>>();

        foreach (var defaultCategory in Constants.Defaults)
        {
            var combinedCategory = new Dictionary<string, object>(defaultCategory.Value);

            // Apply user-provided overrides and additions
            if (options.TryGetValue(defaultCategory.Key, out var userCategory))
            {
                foreach (var kvp in userCategory)
                {
                    combinedCategory[kvp.Key] = kvp.Value; // Override or add
                }
            }

            combinedValues[defaultCategory.Key] = combinedCategory;
        }

        return combinedValues;
    }

    /// <summary>
    /// Replaces predefined variables in the CSS content with the user-provided values.
    /// </summary>
    /// <param name="cssContent">The CSS content to parse.</param>
    /// <param name="combinedValues">The combined values to replace.</param>
    /// <returns>A string of parsed CSS content.</returns>
    private static string ReplacePredefinedVariables(string cssContent, Dictionary<string, Dictionary<string, object>> combinedValues)
    {
        foreach (var valueSet in combinedValues)
        {
            string category = valueSet.Key; // e.g., "spacing"
            var values = valueSet.Value;

            // Match CSS variables like --spacing-1, --sizing-xs, etc.
            var regex = new Regex($@"var\(--{category}([\w-]+)\)", RegexOptions.Compiled);

            cssContent = regex.Replace(cssContent, match =>
            {
                var key = match.Groups[1].Value.TrimStart('-'); // e.g., "1", "xs"
                return values.TryGetValue(key, out var value) ? value?.ToString() ?? match.Value : match.Value;
            });
        }

        return cssContent;
    }

    /// <summary>
    /// Generates custom CSS classes for user-provided values.
    /// </summary>
    /// <param name="combinedValues">The combined values to generate classes for.</param>
    /// <returns>A string of custom CSS classes.</returns>
    private static string GenerateCustomClasses(Dictionary<string, Dictionary<string, object>> combinedValues)
    {
        var sb = new StringBuilder();

        foreach (var valueSet in combinedValues)
        {
            string category = valueSet.Key; // e.g., "spacing"
            var values = valueSet.Value;

            // Fetch the corresponding template for the category
            var template = TemplateRegistry.GetTemplate(category);

            if (template != null)
            {
                foreach (var kvp in values)
                {
                    string key = kvp.Key; // e.g., "9", "custom"
                    object value = kvp.Value;

                    // Skip predefined values (only generate classes for custom keys)
                    if (!Constants.Defaults.TryGetValue(category, out var defaultSet) || !defaultSet.ContainsKey(key))
                    {
                        sb.AppendLine(template.GenerateClasses(key, value));
                    }
                }
            }
        }

        return sb.ToString();
    }
}