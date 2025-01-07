namespace Plugin.Maui.Crosswind;

public static class ConfigModule
{
    public static MauiAppBuilder UseCrosswind(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<CrosswindInitializer>();
    }
}