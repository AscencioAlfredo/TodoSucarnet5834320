using TodoSucarnet5834320.Views;
using TodoSucarnet5834320.Data;
using Microsoft.Extensions.Logging;

namespace TodoSucarnet5834320;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<TodoListPage>();
		builder.Services.AddTransient<TodoItemPage>();

		builder.Services.AddSingleton<TodoItemDatabase>();

		return builder.Build();
	}
}
