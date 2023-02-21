using client_manager_maui.Models;

namespace client_manager_maui;

public partial class App : Application
{
	public static Repository Repository { get; private set; }
	public App(Repository repository)
	{
		InitializeComponent();

		MainPage = new AppShell();

		Repository = repository;
		repository.Init();
	}
}
