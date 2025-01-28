using Plugin.Maui.Crosswind.Configuration;

namespace Plugin.Maui.Crosswind.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		CrosswindInitializer.Init(new CrosswindOptionsBuilder().Build());
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}