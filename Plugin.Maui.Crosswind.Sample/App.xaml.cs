namespace Plugin.Maui.Crosswind.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		CrosswindInitializer.Init();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}