namespace Plugin.Maui.Crosswind.Templates;

public static class TemplateRegistry
{
    private static readonly Dictionary<string, ICategoryTemplate> Templates = new()
    {
        { "spacing", new SpaceTemplate() },
        { "sizing", new SizeTemplate() },
        { "colors", new ColorTemplate() },
        { "fonts", new FontTemplate() }
    };

    public static ICategoryTemplate? GetTemplate(string category)
    {
        return Templates.TryGetValue(category, out var template) ? template : null;
    }
}