using GolfCompanion.Services;
using GolfCompanion.ViewModels;
using GolfCompanion.Views;
using Microsoft.Extensions.Logging;

namespace GolfCompanion
{
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
            builder.Services.AddSingleton<CourseInfoService>();
            builder.Services.AddSingleton<CourseViewModel>();
            builder.Services.AddSingleton<InfoPage>();
            builder.Services.AddTransient<RoundInputView>();
            builder.Services.AddTransient<RoundInputViewModel>();
            builder.Services.AddSingleton<TeeSelectionService>();
            return builder.Build();
        }
    }
}
