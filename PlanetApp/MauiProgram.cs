namespace PlanetApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Monsterrat_Medium.ttf", "RegularRegular");
				fonts.AddFont("Monsterrat-Semibold.ttf", "MediumFont");
				fonts.AddFont("Monsterrat-Bold.ttf", "BoldFont");
			});

		return builder.Build();
	}
}
