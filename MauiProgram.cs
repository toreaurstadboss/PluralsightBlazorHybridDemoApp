using Brushtail.FontAwesome.Mobile;
using MauiApp1.Data;
using Microsoft.Extensions.Logging;
//using MauiApp1.Data;

namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseFontAwesome();

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<ICoffeeService, CoffeeService>();

		//builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
