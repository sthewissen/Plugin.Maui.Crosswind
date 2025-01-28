using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests;

public class CssParserSpacingTests
{
    [Fact]
    public void ParseCss_ShouldReplacePredefinedSpacingVariables()
    {
        // Arrange
        var cssContent = @"
                .example { margin: var(--spacing-1); padding: var(--spacing-2); }
                .example-2 { margin: var(--spacing-3); padding: var(--spacing-4); }
                .example-3 { margin: var(--spacing-5); padding: var(--spacing-6); }
                .example-4 { margin: var(--spacing-7); padding: var(--spacing-8); }";

        var options = new CrosswindOptionsBuilder()
            .AddSpacing(spacing =>
            {
                spacing.AddCustom("1", 10);
                spacing.AddCustom("2", 20);
                spacing.AddCustom("3", 30);
                spacing.AddCustom("4", 40);
                spacing.AddCustom("5", 50);
                spacing.AddCustom("6", 60);
                spacing.AddCustom("7", 70);
                spacing.AddCustom("8", 80);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".example { margin: 10; padding: 20; }", result);
        Assert.Contains(".example-2 { margin: 30; padding: 40; }", result);
        Assert.Contains(".example-3 { margin: 50; padding: 60; }", result);
        Assert.Contains(".example-4 { margin: 70; padding: 80; }", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleSpacingDefaultsWhenNoOverridesProvided()
    {
        // Arrange
        var cssContent = @"
                .example {
                    margin: var(--spacing-3);
                    padding: var(--spacing-4);
                }";

        var options = new CrosswindOptionsBuilder().Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains("margin: 12;", result); // Default value for spacing-3
        Assert.Contains("padding: 16;", result); // Default value for spacing-4
    }

    [Fact]
    public void ParseCss_ShouldGenerateNewClassesForCustomSpacingValues()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddSpacing(spacing =>  {
                spacing.AddCustom("9", 36); 
            })
            .Build();
    
        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".m-9 { margin: 36;", result);
        Assert.Contains(".mt-9 { margin-top: 36;", result);
        Assert.Contains(".mb-9 { margin-bottom: 36;", result);
        Assert.Contains(".ml-9 { margin-left: 36;", result);
        Assert.Contains(".mr-9 { margin-right: 36;", result);
        Assert.Contains(".mx-9 { margin-left: 36; margin-right: 36;", result);
        Assert.Contains(".my-9 { margin-top: 36; margin-bottom: 36;", result);
        Assert.Contains(".p-9 { padding: 36;", result);
        Assert.Contains(".pt-9 { padding-top: 36;", result);
        Assert.Contains(".pb-9 { padding-bottom: 36;", result);
        Assert.Contains(".pl-9 { padding-left: 36;", result);
        Assert.Contains(".pr-9 { padding-right: 36;", result);
        Assert.Contains(".px-9 { padding-left: 36; padding-right: 36;", result);
        Assert.Contains(".py-9 { padding-top: 36; padding-bottom: 36;", result);
        Assert.Contains(".basis-9 { flex-basis: 36; }", result);
        Assert.Contains(".gap-9 { row-gap: 36; column-gap: 36; -maui-spacing: 36; }", result);
        Assert.Contains(".gap-x-9 { column-gap: 36; -maui-spacing: 36; }", result);
        Assert.Contains(".gap-y-9 { row-gap: 36; -maui-spacing: 36; }", result);
        Assert.Contains(".size-9 { width: 36; height: 36; }", result);
        Assert.Contains(".w-9 { width: 36; }", result);
        Assert.Contains(".h-9 { height: 36; }", result);
        Assert.Contains(".min-w-9 { min-width: 36; }", result);
        Assert.Contains(".min-h-9 { min-height: 36; }", result);
        Assert.Contains(".max-w-9 { max-width: 36; }", result);
        Assert.Contains(".max-h-9 { max-height: 36; }", result);
    }

    [Fact]
    public void ParseCss_ShouldNotGenerateClassesForDefaultSpacingValues()
    {
        // Arrange
        var cssContent = ".example { margin: 0; }";

        var options = new CrosswindOptionsBuilder()
            .AddSpacing(spacing => {
                spacing.AddCustom("1", 4);
                spacing.AddCustom("9", 36);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.DoesNotContain(".m-1 {", result); // Should not generate for default values
        Assert.Contains(".m-9 {", result); // Should generate for custom key
    }
}