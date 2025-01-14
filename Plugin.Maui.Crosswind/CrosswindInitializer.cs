namespace Plugin.Maui.Crosswind;

public static class CrosswindInitializer
{
    public static void Init()
    {
        // Merge Crosswind styles into the app's resource dictionary
        if (Application.Current?.Resources != null)
        {
            Application.Current.Resources.MergedDictionaries.Add(new Resources.ColorDefinitions());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.SizeDefinitions());

            // Background colors
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Colors.VisualElementStyles());

            // Opacity, visibility, etc.
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Visibility.VisualElementStyles());
            
            // Margin and padding.
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Spacing.VisualElementStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Spacing.ViewStyles());

            // TODO: Text colors
            // TODO: Scale, Rotate, Translate
            // TODO: Borders (Style, Width, Radius, Color)
            // TODO: Shadows + Shadow Colors
            // TODO: Word Break
            // TODO: Vertical Align
            // TODO: Text Align
            // TODO: Sizing (Width, Height, MaxHeight, MinHeight, MaxWidth, MinWidth, Size)

            // Text sizes, colors etc.
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.LabelStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.ButtonStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.InputViewStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.PickerStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.RadioButtonStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.DatePickerStyles());
            Application.Current.Resources.MergedDictionaries.Add(new Resources.Typography.TimePickerStyles());
        }
    }
}