namespace Plugin.Maui.Crosswind.Templates;

public class SizeTemplate : ICategoryTemplate
{
    public string GenerateClasses(string key, object value)
    {
        return $".text-{key} {{ font-size: {value}; }}\n";
    }
}