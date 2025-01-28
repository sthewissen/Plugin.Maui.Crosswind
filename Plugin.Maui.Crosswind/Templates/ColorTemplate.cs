namespace Plugin.Maui.Crosswind.Templates;

public class ColorTemplate : ICategoryTemplate
{
    public string GenerateClasses(string key, object value)
    {
        if (value is string color)
        {
            return  $".bg-{key} {{ background-color: {color}; }}\n" +
                    $".text-{key} {{ color: {color}; }}\n";
        }
        else if (value is Dictionary<int, string> dictionary)
        {
            var result = string.Empty;
            
            foreach(var item in dictionary)
            {
                result += $".bg-{key}-{item.Key} {{ background-color: {item.Value}; }}\n" +
                          $".text-{key}-{item.Key} {{ color: {item.Value}; }}\n";
            }

            return result;
        }

        return string.Empty;
    }
}