using client_manager_maui.Models;

namespace client_manager_maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "clientmanager.db");
		builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<Repository>(s, dbPath));
		return builder.Build();
	}
}
