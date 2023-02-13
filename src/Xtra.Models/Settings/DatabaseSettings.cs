namespace Xtra.Models.Settings;

public class DatabaseSettings
{
    public string? ConnectionString { get; set; }
    public DatabasePlatform Platform { get; set; }
}