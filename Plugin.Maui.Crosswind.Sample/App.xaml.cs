using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		CrosswindInitializer.Init(new CrosswindOptionsBuilder()
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