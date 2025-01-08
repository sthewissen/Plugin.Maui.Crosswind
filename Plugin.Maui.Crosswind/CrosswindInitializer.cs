namespace Plugin.Maui.Crosswind;

public class CrosswindInitializer
{
    public CrosswindInitializer()
    {
        // Merge Crosswind styles into the app's resource dictionary
        if (Application.Current?.Resources != null)
        {
            Application.Current.Resources.MergedDictionaries.Add(new Resources.ColorDefinitions());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.LabelStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.ButtonStyles());
        }
    }
}