using Microsoft.Extensions.Logging;

namespace MySolarSystem;

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
                fonts.AddFont("NexaRegular.ttf", "NexaRegular");
                fonts.AddFont("NexaHeavy.ttf", "NexaHeavy");
                fonts.AddFont("NexaBook.ttf", "NexaBook");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
