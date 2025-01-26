using System.Collections.Generic;
using Xunit;
using Plugin.Maui.Crosswind;

namespace Plugin.Maui.Crosswind.Tests;

    public class CssParserTests
    {
        [Fact]
        public void ParseCss_ShouldReplacePredefinedVariables()
        {
            // Arrange
            var cssContent = @"
                .example {
                    margin: --spacing-1;
                    padding: --spacing-2;
                }";
            var options = new CrosswindOptions
            {
                {
                    "spacing", new Dictionary<string, object>
                    {
                        { "1", 10 },
                        { "2", 20 }
                    }
                }
            };

            // Act
            var result = CssParser.Parse(options, cssContent);

            // Assert
            Assert.Contains(".example {", result);
            Assert.Contains("margin: 10;", result);
            Assert.Contains("padding: 20;", result);
        }

        [Fact]
        public void ParseCss_ShouldHandleDefaultsWhenNoOverridesProvided()
        {
            // Arrange
            var cssContent = @"
                .example {
                    margin: --spacing-3;
                    padding: --spacing-4;
                }";

            // Act
            var result = CssParser.Parse(new CrosswindOptions(), cssContent);

            // Assert
            Assert.Contains("margin: 12;", result); // Default value for spacing-3
            Assert.Contains("padding: 16;", result); // Default value for spacing-4
        }

        [Fact]
        public void ParseCss_ShouldGenerateNewClassesForCustomValues()
        {
            // Arrange
            var cssContent = ".example { margin: 0; }";
            var options = new CrosswindOptions
            {
                {
                    "spacing", new Dictionary<string, object>
                    {
                        { "9", 36 } // User-defined key
                    }
                }
            };

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

            // TODO: Add the other cases
        }

        [Fact]
        public void ParseCss_ShouldNotGenerateClassesForDefaultValues()
        {
            // Arrange
            var cssContent = ".example { margin: 0; }";
            var options = new CrosswindOptions
            {
                {
                    "spacing", new Dictionary<string, object>
                    {
                        { "1", 4 }, // Same as default value
                        { "9", 36 } // Custom key
                    }
                }
            };

            // Act
            var result = CssParser.Parse(options, cssContent);

            // Assert
            Assert.DoesNotContain(".m-1 {", result); // Should not generate for default values
            Assert.Contains(".m-9 {", result); // Should generate for custom key
        }

        [Fact]
        public void ParseCss_ShouldIgnoreUnknownCategories()
        {
            // Arrange
            var cssContent = ".example { margin: 0; }";
            var options = new CrosswindOptions
            {
                {
                    "unknown-category", new Dictionary<string, object>
                    {
                        { "key", 42 }
                    }
                }
            };

            // Act
            var result = CssParser.Parse(options, cssContent);

            // Assert
            Assert.DoesNotContain(".unknown-category", result); // Unknown categories should not affect output
        }

        [Fact]
        public void ParseCss_ShouldHandleMultipleCategories()
        {
            // Arrange
            var cssContent = @"
                .example {
                    margin: --spacing-1;
                    font-size: --sizing-xl;
                }";
            var options = new CrosswindOptions
            {
                {
                    "spacing", new Dictionary<string, object>
                    {
                        { "1", 8 } // Override default
                    }
                },
                {
                    "sizing", new Dictionary<string, object>
                    {
                        { "xl", 22 } // Override default
                    }
                }
            };

            // Act
            var result = CssParser.Parse(options, cssContent);

            // Assert
            Assert.Contains("margin: 8;", result); // Spacing override
            Assert.Contains("font-size: 22;", result); // Sizing override
        }
    }