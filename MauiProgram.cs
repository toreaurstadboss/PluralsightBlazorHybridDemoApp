﻿using Brushtail.FontAwesome.Mobile;
using MauiApp1.Auth;
using MauiApp1.Data;
using MauiApp1.Library.Data;
using Microsoft.AspNetCore.Components.Authorization;
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
		builder.Services.AddAuthorizationCore();
		builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<ICoffeeService, CoffeeService>();

		//builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
