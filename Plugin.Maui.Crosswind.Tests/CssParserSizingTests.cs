using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests;

public class CssParserSizingTests
{

    [Fact]
    public void ParseCss_ShouldReplacePredefinedSizingVariables()
    {
        // Arrange
        var cssContent = @"
                .example {
                    font-size: var(--sizing-xl);
                }";

        var options = new CrosswindOptionsBuilder()
            .AddSizing(sizing =>
            {
                sizing.AddCustom("xl", 22);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".example {", result);
        Assert.Contains("font-size: 22;", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleSizingDefaultsWhenNoOverridesProvided()
    {
        // Arrange
        var cssContent = @"
                .example {
                    font-size: var(--sizing-md);
                }";

        var options = new CrosswindOptionsBuilder().Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains("font-size: 16;", result); // Default value for sizing-md
    }

    [Fact]
    public void ParseCss_ShouldGenerateNewClassesForCustomSizingValues()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddSizing(sizing => {
                sizing.AddCustom("xxxl", 72);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".text-xxxl { font-size: 72; }", result); // Custom sizing class
    }

    [Fact]
    public void ParseCss_ShouldNotGenerateClassesForDefaultSizingValues()
    {
        // Arrange
        var cssContent = ".example { font-size: 0; }";
        var options = new CrosswindOptionsBuilder()
            .AddSizing(sizing =>
            {
                sizing.AddCustom("md", 16);
                sizing.AddCustom("xxxl", 72);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.DoesNotContain(".text-md {", result); // Should not generate for default values
        Assert.Contains(".text-xxxl {", result); // Should generate for custom key
    }
}
