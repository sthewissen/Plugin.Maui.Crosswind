namespace Plugin.Maui.Crosswind;

public class Constants
{
    // Developer-defined defaults
    public static readonly Dictionary<string, Dictionary<string, object>> Defaults = new()
    {
        { "spacing", new Dictionary<string, object>
            {
                {"0",  0d },
                { "1", 4d },
                { "2", 8d },
                { "3", 12d },
                { "4", 16d },
                { "5", 20d },
                { "6", 24d },
                { "7", 28d },
                { "8", 32d }
            }
        },
        { "sizing", new Dictionary<string, object>
            {
                { "xs", 12d },
                { "sm", 14d },
                { "md", 16d },
                { "lg", 18d },
                { "xl", 20d },
                { "2xl", 24d },
                { "3xl", 30d },
                { "4xl", 36d },
                { "5xl", 48d },
                { "6xl", 64d }
            }
        },
        {
            "colors", new Dictionary<string, object>
            {
            }
        },
        { "fonts", new Dictionary<string, object>
            {
                { "sans", "sans-serif" },
                { "serif", "serif" },
                { "mono", "monospace" },
            }
        }
    };
}