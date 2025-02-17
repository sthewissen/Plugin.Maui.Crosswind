namespace Plugin.Maui.Crosswind.Templates;

public class FontTemplate : ICategoryTemplate
{
    public string GenerateClasses(string key, object value)
    {
        return $".font-{key} {{ font-family: {value}; }}\n";
    }
}