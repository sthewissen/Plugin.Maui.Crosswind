namespace Plugin.Maui.Crosswind.Templates;

public class SpacingTemplate : ICategoryTemplate
{
    public string GenerateClasses(string key, object value)
    {
        return $".m-{key} {{ margin: {value}; }}\n" +
               $".mx-{key} {{ margin-left: {value}; margin-right: {value}; }}\n" +
               $".my-{key} {{ margin-top: {value}; margin-bottom: {value}; }}\n" +
               $".mt-{key} {{ margin-top: {value}; }}\n" +
               $".mr-{key} {{ margin-right: {value}; }}\n" +
               $".mb-{key} {{ margin-bottom: {value}; }}\n" +
               $".ml-{key} {{ margin-left: {value}; }}\n" +
               $".p-{key} {{ padding: {value}; }}\n" +
               $".px-{key} {{ padding-left: {value}; padding-right: {value}; }}\n" +
               $".py-{key} {{ padding-top: {value}; padding-bottom: {value}; }}\n" +
               $".pt-{key} {{ padding-top: {value}; }}\n" +
               $".pr-{key} {{ padding-right: {value}; }}\n" +
               $".pb-{key} {{ padding-bottom: {value}; }}\n" +
               $".pl-{key} {{ padding-left: {value}; }}\n" +
               $".basis-{key} {{ flex-basis: {value}; }}\n" +
               $".gap-{key} {{ row-gap: {value}; column-gap: {value}; -maui-spacing: {value}; }}\n" +
               $".gap-x-{key} {{ column-gap: {value}; -maui-spacing: {value}; }}\n" +
               $".gap-y-{key} {{ row-gap: {value}; -maui-spacing: {value}; }}\n" +
               $".size-{key} {{ width: {value}; height: {value}; }}\n" +
               $".w-{key} {{ width: {value}; }}\n" +
               $".h-{key} {{ height: {value}; }}\n" +
               $".min-w-{key} {{ min-width: {value}; }}\n" +
               $".min-h-{key} {{ min-height: {value}; }}\n" +
               $".max-w-{key} {{ max-width: {value}; }}\n" +
               $".max-h-{key} {{ max-height: {value}; }}\n";
    }
}