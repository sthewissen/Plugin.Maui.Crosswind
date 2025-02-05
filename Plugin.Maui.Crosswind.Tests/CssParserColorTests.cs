using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests;

public class CssParserColorTests
{
    [Fact]
    public void ParseCss_ShouldGenerateClassesForFlatColor()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("white", "#ffffff");
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-white { background-color: #ffffff; }", result);
        Assert.Contains(".text-white { color: #ffffff; }", result);
        Assert.Contains(".border-white { border-color: #ffffff; }", result);
    }

    [Fact]
    public void ParseCss_ShouldGenerateClassesForPaletteColors()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddPalette("tahiti", palette =>
                {
                    palette.AddShade(100, "#cffafe");
                    palette.AddShade(200, "#a5f3fc");
                    palette.AddShade(300, "#67e8f9");
                });
            })
           .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-tahiti-100 { background-color: #cffafe; }", result);
        Assert.Contains(".text-tahiti-100 { color: #cffafe; }", result);
        Assert.Contains(".border-tahiti-100 { border-color: #cffafe; }", result);
        Assert.Contains(".bg-tahiti-200 { background-color: #a5f3fc; }", result);
        Assert.Contains(".text-tahiti-200 { color: #a5f3fc; }", result);
        Assert.Contains(".border-tahiti-200 { border-color: #a5f3fc; }", result);
        Assert.Contains(".bg-tahiti-300 { background-color: #67e8f9; }", result);
        Assert.Contains(".text-tahiti-300 { color: #67e8f9; }", result);
        Assert.Contains(".border-tahiti-300 { border-color: #67e8f9; }", result);
    }

    [Fact]
    public void ParseCss_ShouldIgnoreColorsWithEmptyPalette()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddPalette("empty", palette => { });
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.DoesNotContain(".bg-empty", result);
        Assert.DoesNotContain(".text-empty", result);
        Assert.DoesNotContain(".border-empty", result);
    }

    [Fact]
    public void ParseCss_ShouldHandlePaletteWithNonSequentialKeys()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddPalette("custom", palette =>
                {
                    palette.AddShade(50, "#f9fafb");
                    palette.AddShade(900, "#1c1917");
                });
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-custom-50 { background-color: #f9fafb; }", result);
        Assert.Contains(".text-custom-50 { color: #f9fafb; }", result);
        Assert.Contains(".border-custom-50 { border-color: #f9fafb; }", result);
        Assert.Contains(".bg-custom-900 { background-color: #1c1917; }", result);
        Assert.Contains(".text-custom-900 { color: #1c1917; }", result);
        Assert.Contains(".border-custom-900 { border-color: #1c1917; }", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleMultipleColorsAndPalettes()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("white", "#ffffff");
                colors.AddPalette("tahiti", palette =>
               {
                   palette.AddShade(100, "#cffafe");
               });
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-white { background-color: #ffffff; }", result);
        Assert.Contains(".text-white { color: #ffffff; }", result);
        Assert.Contains(".border-white { border-color: #ffffff; }", result);
        Assert.Contains(".bg-tahiti-100 { background-color: #cffafe; }", result);
        Assert.Contains(".text-tahiti-100 { color: #cffafe; }", result);
        Assert.Contains(".border-tahiti-100 { border-color: #cffafe; }", result);
    }
}
