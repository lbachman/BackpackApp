# Changing the App Icon
- Foreground: 


# Deploying a SQLite Database to an Android Device 
- make sure this isn't present in project file `<None Remove="Resources\Raw\BackpackSQLite.db" />`
- Put this in DbContext
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
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

        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
```