using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests;

public class CssParserFontsTests
{
    [Fact]
    public void ParseCss_ShouldGenerateNewClassesForCustomFontsValues()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddFonts(fonts => {
                fonts.AddCustom("primary", "Comic Sans MS");
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".font-primary { font-family: Comic Sans MS; }", result); // Custom fonts class
    }

    [Fact]
    public void ParseCss_ShouldNotGenerateClassesForDefaultFontsValues()
    {
        // Arrange
        var cssContent = ".example { font-size: 0; }";
        var options = new CrosswindOptionsBuilder()
            .AddFonts(fonts =>
            {
                fonts.AddCustom("primary", "Comic Sans MS");
                fonts.AddCustom("sans", "Wingdings");
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.DoesNotContain(".font-sans {", result); // Should not generate for default values
        Assert.Contains(".font-primary {", result); // Should generate for custom key
    }

    [Fact]
    public void ParseCss_ShouldReplacePredefinedFontsVariables()
    {
        // Arrange
        var cssContent = @"
            .font-sans { font-family: var(--fonts-sans); }
            .font-serif { font-family: var(--fonts-serif); }
            .font-mono { font-family: var(--fonts-mono); }
        ";
        var options = new CrosswindOptionsBuilder()
            .AddFonts(fonts =>
            {
                fonts.AddCustom("sans", "Arial");
                fonts.AddCustom("serif", "Times New Roman");
                fonts.AddCustom("mono", "Courier New");
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".font-sans { font-family: Arial; }", result);
        Assert.Contains(".font-serif { font-family: Times New Roman; }", result);
        Assert.Contains(".font-mono { font-family: Courier New; }", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleFontsDefaultsWhenNoOverridesProvided()
    {
        // Arrange
        var cssContent = @"
            .font-sans { font-family: var(--fonts-sans); }
            .font-serif { font-family: var(--fonts-serif); }
            .font-mono { font-family: var(--fonts-mono); }
        ";
        var options = new CrosswindOptionsBuilder().Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".font-sans { font-family: sans-serif; }", result);
        Assert.Contains(".font-serif { font-family: serif; }", result); // Default value
        Assert.Contains(".font-mono { font-family: monospace; }", result); // Default value
    }

    [Fact]
    public void ParseCss_ShouldThrowForInvalidFontKeys()
    {
        var options = new CrosswindOptionsBuilder()
            .AddFonts(fonts =>
            {
                fonts.AddCustom("inv$alid", "SomeFont");
                fonts.AddCustom("sans", "Arial");
            });

        // Act
        var exception = Assert.Throws<ArgumentException>(() => options.Build());
    }

    [Fact]
    public void ParseCss_ShouldHandleCustomFontNamesCorrectly()
    {
        // Arrange
        var cssContent = @"
            .font-sans { font-family: var(--fonts-sans); }
            .font-serif { font-family: var(--fonts-serif); }
            .font-mono { font-family: var(--fonts-mono); }
        ";

        var options = new CrosswindOptionsBuilder()
            .AddFonts(fonts =>
            {
                fonts.AddCustom("mono", "CustomMonoFont");
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".font-mono { font-family: CustomMonoFont; }", result);
        Assert.Contains(".font-sans { font-family: sans-serif; }", result); // Default value
        Assert.Contains(".font-serif { font-family: serif; }", result); // Default value
    }

    [Fact]
    public void ParseCss_ShouldThrowForNullFontValues()
    {
        // Arrange
        var builder = new CrosswindOptionsBuilder()
            .AddFonts(fonts =>
            {
                fonts.AddCustom("sans", null);
            });

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => builder.Build());
    }
}
