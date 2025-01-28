namespace Plugin.Maui.Crosswind.Configuration;

/// <summary>
/// Builder class for Crosswind options.
/// </summary>
public class CrosswindOptionsBuilder
{
    private readonly CrosswindOptions _options;

    /// <summary>
    /// Initializes a new instance of the <see cref="CrosswindOptionsBuilder"/> class.
    /// </summary>
    public CrosswindOptionsBuilder()
    {
        _options = [];
    }

    public CrosswindOptionsBuilder AddSpacing(Action<SpacingOptions> configure)
    {
        var spacingOptions = new SpacingOptions();
        configure(spacingOptions);
        _options["spacing"] = spacingOptions.GetValues();
        return this;
    }

    public CrosswindOptionsBuilder AddSizing(Action<SizingOptions> configure)
    {
        var sizingOptions = new SizingOptions();
        configure(sizingOptions);
        _options["sizing"] = sizingOptions.GetValues();
        return this;
    }

    public CrosswindOptionsBuilder AddFonts(Action<FontOptions> configure)
    {
        var fontOptions = new FontOptions();
        configure(fontOptions);
        _options["fonts"] = fontOptions.GetValues();
        return this;
    }

    public CrosswindOptionsBuilder AddColors(Action<ColorOptions> configure)
    {
        var colorOptions = new ColorOptions();
        configure(colorOptions);
        _options["colors"] = colorOptions.GetValues();
        return this;
    }

    public CrosswindOptions Build()
    {
        // Perform validation on the options before returning it
        _options.Validate();
        return _options;
    }
}
