namespace Plugin.Maui.Crosswind;

public static class ConfigModule
{
    /// <summary>
    /// Registers Crosswind with the Maui app.
    /// </summary>
    /// <param name="builder">The Maui app builder.</param>
    /// <returns>A Maui app builder with Crosswind support added.</returns>
    public static MauiAppBuilder UseCrosswind(this MauiAppBuilder builder)
    {
        // builder.Services.AddSingleton<CrosswindInitializer>();
        
        //     .ConfigureFonts(fonts =>
        // {
        //     fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        //     fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        // })

        return builder;
    }
}