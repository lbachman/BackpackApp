using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MauiMudBlazor.Helpers;
using MauiMudBlazor.Contexts;
using System.Diagnostics;
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

            string dbPath;

            // Check if the app is running on Windows
            if (OperatingSystem.IsWindows())
            {
                // Use a path relative to the project directory during development
                dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BackpackSQLite.db");
            }
            else
            {
                // Use the app's data directory on other platforms
                dbPath = Path.Combine(FileSystem.AppDataDirectory, "BackpackSQLite.db");
            }

            if (File.Exists(dbPath))
            { 
                File.Delete(dbPath);
            }

            // Check if the database file already exists
            if (!File.Exists(dbPath))
            {
                var assembly = typeof(App).Assembly;
                var resourceName = "Resources.Raw.BackpackSQLite.db";  // Correct resource name based on the output

                using (var resourceStream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (resourceStream == null)
                        throw new FileNotFoundException("Database file not found as an embedded resource.");


                    // Create the database file from the embedded resource if it doesn't exist
                    using (var fileStream = new FileStream(dbPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }

            }




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
