namespace Plugin.Maui.Crosswind.Sample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("RethinkSans-Regular.ttf", "RethinkSans-Regular");
				fonts.AddFont("RethinkSans-Semibold.ttf", "RethinkSans-SemiBold");
				fonts.AddFont("RethinkSans-Bold.ttf", "RethinkSans-Bold");
			});

		return builder.Build();
	}
}
