using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests;

public class CssParserTests
{
    [Fact]
    public void ParseCss_ShouldHandleMultipleCategories()
    {
        // Arrange
        var cssContent = @"
                .example {
                    margin: var(--spacing-1);
                    font-size: var(--sizing-xl);
                }";

        var options = new CrosswindOptionsBuilder()
            .AddSpacing(spacing =>
            {
                spacing.AddCustom("1", 8);
            })
            .AddSizing(sizing =>
            {
                sizing.AddCustom("xl", 22);
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains("margin: 8;", result); // Spacing override
        Assert.Contains("font-size: 22;", result); // Sizing override
    }
}
