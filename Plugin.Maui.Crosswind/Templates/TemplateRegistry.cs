namespace Plugin.Maui.Crosswind.Templates;

public static class TemplateRegistry
{
    private static readonly Dictionary<string, ICategoryTemplate> Templates = new()
    {
        { "spacing", new SpacingTemplate() },
        { "sizing", new SizingTemplate() }
    };

    public static ICategoryTemplate? GetTemplate(string category)
    {
        return Templates.TryGetValue(category, out var template) ? template : null;
    }
}