using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Tests
{
    public class CrosswindOptionsTests
    {
        [Fact]
        public void Validate_ShouldPassForValidSpacingOptions()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder()
                .AddSpacing(spacing =>
                {
                    spacing.AddCustom("1", 4);
                    spacing.AddCustom("2", 8);
                });

            // Act & Assert
            options.Build(); // Should not throw
        }

        [Fact]
        public void Validate_ShouldPassForValidSizingOptions()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder()
                .AddSizing(sizing =>
                {
                    sizing.AddCustom("lg", 32);
                    sizing.AddCustom("xl", 48);
                });

            // Act & Assert
            options.Build(); // Should not throw
        }

        [Fact]
        public void Validate_ShouldPassForValidFontsOptions()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder()
                .AddFonts(fonts =>
                {
                    fonts.AddCustom("sans-serif", "Arial");
                    fonts.AddCustom("serif", "Courier New");
                });

            // Act & Assert
            options.Build(); // Should not throw
        }

        [Fact]
        public void Validate_ShouldPassForValidColorsOptions()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder()
                .AddColors(colors =>
                {
                    colors.AddCustom("primary", "#FF0000");
                    colors.AddCustom("secondary", new Dictionary<int, string>
                        {
                            { 100, "#FFCCCC" },
                            { 200, "#FF9999" }
                        });
                });

            // Act & Assert
            options.Build(); // Should not throw
        }

        [Fact]
        public void Validate_ShouldThrowForInvalidCssClassName()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder()
                .AddSpacing(spacing =>
                {
                    spacing.AddCustom("1-in$valid", 4); // Invalid CSS class name
                });

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => options.Build());
            Assert.Contains("Invalid CSS class name: '1-in$valid'", exception.Message);
        }

        [Fact]
        public void Validate_ShouldPassWithValidDefaults()
        {
            // Arrange
            var options = new CrosswindOptionsBuilder();

            // Act & Assert
            options.Build(); // Should not throw
        }
    }
}
