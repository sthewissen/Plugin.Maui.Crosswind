namespace Plugin.Maui.Crosswind;

public static class ConfigModule
{
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