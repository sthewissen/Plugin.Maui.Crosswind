using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		CrosswindInitializer.Init(new CrosswindOptionsBuilder()
			.AddSpacing(options =>
			{
				options.AddCustom("9", 36);
				options.AddCustom("10", 40);
				options.AddCustom("11", 44);
			})
			.AddSizing(options =>
			{
				options.AddCustom("8xl", 96);
			})
			.AddColors(options =>
			{
				options.AddCustom("primary", "#FE5E12");
				options.AddPalette("cocoa", palette =>
				{
					palette.AddShade(50, "#F8EFE8");
					palette.AddShade(100, "#F1DED0");
					palette.AddShade(200, "#E4C0A5");
					palette.AddShade(300, "#D59F76");
					palette.AddShade(400, "#C77F47");
					palette.AddShade(500, "#A46432");
					palette.AddShade(600, "#754724");
					palette.AddShade(700, "#482C16");
					palette.AddShade(800, "#2F1C0E");
					palette.AddShade(900, "#170E07");
					palette.AddShade(950, "#0C0704");
				});
			})
			.AddFonts(options =>
			{
				options.AddCustom("bold", "RethinkSans-Bold");
				options.AddCustom("regular", "RethinkSans-Regular");
				options.AddCustom("semibold", "RethinkSans-SemiBold");
			})
			.Build());
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}