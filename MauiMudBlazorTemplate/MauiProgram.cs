using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MauiMudBlazor.Helpers;
using MauiMudBlazor.Contexts;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Storage;
using Android.Content;
using Microsoft.Maui.Storage;
using System.IO;
using Microsoft.Maui.Controls.PlatformConfiguration;

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
            builder.Services.AddSingleton<BackpackAppContext>();


            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "BackpackSQLite.db");

            // Check if the database already exists
            if (!File.Exists(dbPath))
            {
                using (var rawStream = Android.App.Application.Context.Resources.OpenRawResource(Resource.Raw.backpacksqlite))
                using (var fileStream = new FileStream(dbPath, FileMode.Create, FileAccess.Write))
                {
                    rawStream.CopyTo(fileStream);
                }
            }

            Debug.WriteLine($"Database Path: {dbPath}");




            Debug.WriteLine($"Database Path: {dbPath}");
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
