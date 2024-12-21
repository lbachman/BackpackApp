using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MauiMudBlazor.Helpers;
using MauiMudBlazor.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Storage;
using System.IO;

namespace MauiMudBlazor
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
                });
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<EventHandleHelper>();

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "BackpackSQLite.db"); 

            if (!File.Exists(dbPath))
            {
                var assembly = typeof(App).Assembly;
                var resourceName = "MauiMudBlazor.Resources.Raw.BackpackSQLite.db";

                using (var resourceStream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (resourceStream == null)
                        throw new FileNotFoundException("Database file not found as an embedded resource.");

                    using (var fileStream = new FileStream(dbPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }
            }


            builder.Services.AddDbContext<BackpackAppContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
