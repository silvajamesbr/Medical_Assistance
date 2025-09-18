using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using Medical_Assistance.Services;

namespace Medical_Assistance
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
            builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "medical.db3");
            builder.Services.AddSingleton<DatabaseHelper>(s => new DatabaseHelper(dbPath));


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
