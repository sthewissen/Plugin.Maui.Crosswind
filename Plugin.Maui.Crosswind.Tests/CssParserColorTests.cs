using Plugin.Maui.Crosswind.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    [Fact]
    public void ParseCss_ShouldGenerateClassesForNestedColors()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("tahiti", new Dictionary<int, string>
                {
                    { 100, "#cffafe" },
                    { 200, "#a5f3fc" },
                    { 300, "#67e8f9" }
                });
            })
           .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-tahiti-100 { background-color: #cffafe; }", result);
        Assert.Contains(".text-tahiti-100 { color: #cffafe; }", result);
        Assert.Contains(".bg-tahiti-200 { background-color: #a5f3fc; }", result);
        Assert.Contains(".text-tahiti-200 { color: #a5f3fc; }", result);
        Assert.Contains(".bg-tahiti-300 { background-color: #67e8f9; }", result);
        Assert.Contains(".text-tahiti-300 { color: #67e8f9; }", result);
    }

    [Fact]
    public void ParseCss_ShouldIgnoreColorsWithEmptyDictionary()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("empty", new Dictionary<int, string>());
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.DoesNotContain(".bg-empty", result);
        Assert.DoesNotContain(".text-empty", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleColorsWithNonSequentialKeys()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("custom", new Dictionary<int, string>
                {
                    { 50, "#f9fafb" },
                    { 900, "#1c1917" }
                });
            })
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-custom-50 { background-color: #f9fafb; }", result);
        Assert.Contains(".text-custom-50 { color: #f9fafb; }", result);
        Assert.Contains(".bg-custom-900 { background-color: #1c1917; }", result);
        Assert.Contains(".text-custom-900 { color: #1c1917; }", result);
    }

    [Fact]
    public void ParseCss_ShouldHandleMultipleColorsAndCategories()
    {
        // Arrange
        var cssContent = string.Empty;
        var options = new CrosswindOptionsBuilder()
            .AddColors(colors =>
            {
                colors.AddCustom("white", "#ffffff");
                colors.AddCustom("tahiti", new Dictionary<int, string>
                {
                    { 100, "#cffafe" }
                });
            }) 
            .Build();

        // Act
        var result = CssParser.Parse(options, cssContent);

        // Assert
        Assert.Contains(".bg-white { background-color: #ffffff; }", result);
        Assert.Contains(".text-white { color: #ffffff; }", result);
        Assert.Contains(".bg-tahiti-100 { background-color: #cffafe; }", result);
        Assert.Contains(".text-tahiti-100 { color: #cffafe; }", result);
    }
}
