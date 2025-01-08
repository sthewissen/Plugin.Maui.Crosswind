using Microsoft.Extensions.Logging;

namespace Plugin.Maui.Crosswind.Sample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseCrosswind();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
